using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Abp.Extensions;

namespace TCC.OUSyncService.Entities
{
    public class TccOrgnization : FullAuditedEntity
    {
        public TccOrgnization(string codeItemId, string codeItemDesc, string parentCodeItemId)
        {
            CodeItemId = codeItemId.IsNullOrEmpty() ? throw new ArgumentException("CodeItemId不能为Null") : codeItemId;
            CodeItemDesc = codeItemDesc.IsNullOrEmpty()
                ? throw new ArgumentException("CodeItemId不能为Null")
                : codeItemDesc;
            ParentCodeItemId = parentCodeItemId;
        }

        protected TccOrgnization()
        {
        }

        /// <summary>
        /// 部门编码
        /// </summary>
        [MaxLength(30)]
        public string CodeItemId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [MaxLength(300)]
        public string CodeItemDesc { get; set; }

        /// <summary>
        /// 上级部门代码
        /// </summary>
        [MaxLength(30)]
        public string ParentCodeItemId { get; set; }

        /// <summary>
        /// 是否是OU根节点
        /// </summary>
        /// <returns>是---否</returns>
        public bool IsRootOU()
        {
            return ParentCodeItemId == CodeItemId;
        }
    }
}