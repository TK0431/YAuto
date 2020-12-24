using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YAuto.Model.DB
{
    public class BaseTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [Required, StringLength(6)]
        public string UpdateId { get; set; }

        /// <summary>
        /// 做成时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 做成者
        /// </summary>
        [Required, StringLength(6)]
        public string CreateId { get; set; }
    }
}
