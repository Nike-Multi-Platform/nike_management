﻿using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibDAL
{
    public class UserAccountRepository
    {
        private readonly DbContextDataContext _db;
        public UserAccountRepository(DbContextDataContext db)
        {
            _db = db;

        }
        public int Save(UserAccountDTO user)
        {
            try
            {
                _db.user_accounts.InsertOnSubmit(AutoMapperConfig.Mapper.Map<UserAccountDTO, user_account>(user));
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public UserAccountDTO GetAccount(string email, string password)
        {
            //return objectMapper.AccountMapperToEnity(_db.user_accounts.Where(o => o.user_email == email && o.user_password == password).FirstOrDefault());
            user_account u = _db.user_accounts.Where(o => o.user_email == email && o.password == password).FirstOrDefault();
            return AutoMapperConfig.Mapper.Map<user_account, UserAccountDTO>(u);
        }

        public int Login(string username, string password)
        {
            try
            {
                var user = _db.user_accounts
                    .FirstOrDefault(o => o.user_username == username
                                         && o.password == password
                                         && (o.role_id == 3 || o.role_id == 2));

                return user != null ? 1 : 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during login: {ex.Message}");
                return -1;
            }
        }

        public List<UserAccountDTO> GetListAccounts()
        {
            List<UserAccountDTO> l = _db.user_accounts.Select(emp => AutoMapperConfig.Mapper.Map<user_account, UserAccountDTO>(emp)).ToList();
            return l;
        }
        public UserAccountDTO GetUser(string id)
        {
            user_account u = _db.user_accounts.Where(user => user.user_id == id).FirstOrDefault();
            return AutoMapperConfig.Mapper.Map<user_account, UserAccountDTO>(u);
        }

        public int Edit(UserAccountDTO user)
        {
            try
            {
                var existingUser = _db.user_accounts.FirstOrDefault(u => u.user_id == user.user_id);
                if (existingUser != null)
                {
                    existingUser.user_first_name = user.user_first_name;
                    existingUser.user_last_name = user.user_last_name;
                    existingUser.password = user.user_password;
                    existingUser.user_gender = user.user_gender;
                    existingUser.user_address = user.user_address;
                    existingUser.user_url = user.user_url;
                    existingUser.user_phone_number = user.user_phone_number;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Delete(string id)
        {
            try
            {
                var userTemp = _db.user_accounts.Where(o => o.user_id == id).FirstOrDefault();
                _db.user_accounts.DeleteOnSubmit(userTemp);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<UserAccountDTO> Search(string inputSearch)
        {
            try
            {
                bool isNumericSearch = int.TryParse(inputSearch, out int numericSearch);
                List<UserAccountDTO> result = _db.user_accounts
                    .Where(user => user.user_username.Contains(inputSearch) ||
                                            user.user_email.Contains(inputSearch) ||
                                            user.user_phone_number.Contains(inputSearch) ||
                                            user.user_address.Contains(inputSearch) ||
                                            user.user_first_name.Contains(inputSearch) ||
                                            user.user_last_name.Contains(inputSearch)).ToList().Select(o => AutoMapperConfig.Mapper.Map<user_account, UserAccountDTO>(o)).ToList();

                if (result != null)
                {
                    return result;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
