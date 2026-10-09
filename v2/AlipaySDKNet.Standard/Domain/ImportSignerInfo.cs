using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImportSignerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ImportSignerInfo : AopObject
    {
        /// <summary>
        /// 创建失败原因
        /// </summary>
        [XmlElement("import_fail_message")]
        public string ImportFailMessage { get; set; }

        /// <summary>
        /// 创建结果，true表示创建成功,false表示创建失败
        /// </summary>
        [XmlElement("import_status")]
        public bool ImportStatus { get; set; }

        /// <summary>
        /// 签约人通知失败原因
        /// </summary>
        [XmlElement("signer_notice_message")]
        public string SignerNoticeMessage { get; set; }

        /// <summary>
        /// 协议签约人员工号
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }
    }
}
