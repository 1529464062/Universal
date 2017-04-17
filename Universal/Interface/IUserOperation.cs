using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// 用户操作接口
    /// </summary>
    public interface IUserOperation
    {
        /// <summary>
        /// 接口：判断用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPassWord">用户密码</param>
        /// <returns>true：用户存在，false：用户不存在，或用户名，密码错误</returns>
        bool UserIsExist(string userName, string userPassWord);
        /// <summary>
        /// 接口：更新用户密码
        /// </summary>
        /// <param name="UserID">用户表ID</param>
        /// <param name="UserPassWord">用户密码</param>
        /// <returns>更新成功或失败</returns>
        bool UpdateUserPassWord(int UserID, string UserPassWord);
    }
}
