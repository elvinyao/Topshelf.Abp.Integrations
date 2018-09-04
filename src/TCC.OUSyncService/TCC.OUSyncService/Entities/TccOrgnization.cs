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
            CodeItemId = codeItemId.IsNullOrEmpty() ? throw new ArgumentException("CodeItemId����ΪNull") : codeItemId;
            CodeItemDesc = codeItemDesc.IsNullOrEmpty()
                ? throw new ArgumentException("CodeItemId����ΪNull")
                : codeItemDesc;
            ParentCodeItemId = parentCodeItemId;
        }

        protected TccOrgnization()
        {
        }

        /// <summary>
        /// ���ű���
        /// </summary>
        [MaxLength(30)]
        public string CodeItemId { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [MaxLength(300)]
        public string CodeItemDesc { get; set; }

        /// <summary>
        /// �ϼ����Ŵ���
        /// </summary>
        [MaxLength(30)]
        public string ParentCodeItemId { get; set; }

        /// <summary>
        /// �Ƿ���OU���ڵ�
        /// </summary>
        /// <returns>��---��</returns>
        public bool IsRootOU()
        {
            return ParentCodeItemId == CodeItemId;
        }
    }
}