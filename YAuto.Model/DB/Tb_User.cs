using System.ComponentModel.DataAnnotations;

namespace YAuto.Model.DB
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Tb_User:BaseTable
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Required,StringLength(6)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(10)]
        public string UserName { get; set; }

        /// <summary>
        /// 所属组
        /// </summary>
        [StringLength(4)]
        public string GroupId { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public int Level { get; set; }
    }
}
