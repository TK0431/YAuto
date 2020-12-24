using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YAuto.Model.DB
{
    public class Tb_Project : BaseTable
    {
        /// <summary>
        /// 工程ID
        /// </summary>
        [Required, StringLength(6)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工程名
        /// </summary>
        [StringLength(50)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [StringLength(6)]
        public string AuthorId { get; set; }
    }
}
