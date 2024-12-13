using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;

namespace LibBLL
{
    public class UserAccountManager : IRepository<UserAccountDTO>
    {
        private readonly UserAccountRepository _accountRepository;

        public UserAccountManager()
        { 
        }

        public UserAccountManager(UserAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        /// <summary>
        /// thêm khách hàng vào bên trong , đầu vào là 1 UserAccountDTO
        /// </summary>
        /// <param name="user"></param>
        /// <returns>1 nếu thành công, 0 thì thêm thất bại liên hệ thằng Vinh debug cho</returns>
        /// 
/*        public UserAccountManager()
        {
            _accountRepository = new UserAccountRepository(new DbContextDataContext());
        }*/
        public int InsertUser(UserAccountDTO user)
        {
            // logic here!
            try
            {
                _accountRepository.Save(user);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // get account for auth
        /// <summary>
        /// lấy thông tin tài khoản của 1 account , truyền vào là mail , password để xác thực
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        /// <returns> trả về 1 đối tượng UserAccountDTO</returns>
        public UserAccountDTO GetAccount(string mail, string password)
        {
            // hash here! update sau
            return _accountRepository.GetAccount(mail, password);
        }
        // get list users
        /// <summary>
        /// lấy danh sách thông tin của tài khoản
        /// </summary>
        /// <returns>null nếu rỗng</returns>
        public List<UserAccountDTO> GetUserAccounts()
        {
            return _accountRepository.GetListAccounts();
        }

        // get user by id
        /// <summary>
        /// Lấy thông tin tài khoản thông qua mã ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserAccountDTO GetUserByID(string id)
        {
            return _accountRepository.GetUser(id);
        }

        /// <summary>
        ///  chỉnh sửa thông tin tài khoản
        /// </summary>
        /// <param name="user"></param>
        /// <returns>1: thành công, 0: thất bại</returns>
        public int EditUser(UserAccountDTO user)
        {
            return _accountRepository.Edit(user);
        }
        // delete user

        /// <summary>
        ///  hàm xóa 1 user, tham số truyền vào là 1 int khóa chính của user đó
        /// </summary>
        /// <param name="id"></param>
        /// <returns>   1 - xóa thành công , 0 - xóa thất bại</returns>
        public int DeleleUser(string id)
        {
            return _accountRepository.Delete(id);
        }
        // search - input
        /// <summary>
        /// tìm kiếm mọi thông tin bất kỳ liên quan đến user ( trừ mật khẩu )
        /// </summary>
        /// <param name="inputSearch"></param>
        /// <returns>trả về danh sách user liên quan đến input , null nếu rỗng</returns>
        public List<UserAccountDTO> SearchUser(string inputSearch)
        {
            return _accountRepository.Search(inputSearch);
        }
        // ==============================================================================
        //============================== bên dưới đây là code riêng. phần mở rộng mới
        // code mới hoàn toàn
        // !!!
        public int Add(UserAccountDTO entity)
        {
            return _accountRepository.Save(entity);
        }

        public int Delete(string id)
        {
            return _accountRepository.Delete(id);
        }

        public int Update(UserAccountDTO enity)
        {
            return _accountRepository.Edit(enity);
        }

        public IEnumerable<UserAccountDTO> Search(string search)
        {
            return _accountRepository.Search(search);
        }

        public IEnumerable<UserAccountDTO> GetAll()
        {
            return _accountRepository.GetListAccounts();
        }

        public UserAccountDTO GetByID(string id)
        {
            return _accountRepository.GetUser(id);
        }

        public string Name()
        {
            return "User account";
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccountDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

    }
}
