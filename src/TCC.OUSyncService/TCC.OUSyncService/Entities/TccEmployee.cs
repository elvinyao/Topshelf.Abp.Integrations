using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCC.OUSyncService.Entities
{
    public class TccEmployee : FullAuditedEntity
    {
        protected TccEmployee()
        {
        }

        public TccEmployee(int orgnizationBelongedId, string employeeId,
            string name, string account, Gender gender, DateTime entryDate, string nation, string nativePlace,
            string political, string position, string unitLevel, string emailAddress, string telephone, string userKey)
        {
            OrgnizationBelongedId = orgnizationBelongedId;
            EmployeeId = employeeId;
            Name = name;
            Account = account;
            Gender = gender;
            EntryDate = entryDate;
            Nation = nation;
            NativePlace = nativePlace;
            Political = political;
            Position = position;
            UnitLevel = unitLevel;
            EmailAddress = emailAddress;
            Telephone = telephone;
            UserKey = userKey;
        }

        /// <summary>
        /// 所属部门主键
        /// </summary>
        public int OrgnizationBelongedId { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        [ForeignKey("OrgnizationBelongedId")]
        public TccOrgnization OrgnizationBelonged { get; set; }

        /// <summary>
        /// 员工HRP编码，唯一
        /// </summary>
        [MaxLength(50)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 登陆帐号
        /// </summary>
        [MaxLength(50)]
        public string Account { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// 入职日期
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [MaxLength(30)]
        public string Nation { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [MaxLength(100)]
        public string NativePlace { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        [MaxLength(50)]
        public string Political { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [MaxLength(50)]
        public string Position { get; set; }

        /// <summary>
        /// 职级
        /// </summary>
        [MaxLength(50)]
        public string UnitLevel { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [MaxLength(60)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [MaxLength(50)]
        public string Telephone { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [MaxLength(50)]
        public string UserKey { get; set; }

        /// <summary>
        /// 兼职部门主键
        /// </summary>
        public int? JZOrgnizationBelongedId { get; set; }
    }
}