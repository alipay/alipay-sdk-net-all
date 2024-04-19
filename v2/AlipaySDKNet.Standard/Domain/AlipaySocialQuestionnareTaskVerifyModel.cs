using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialQuestionnareTaskVerifyModel : AopObject
    {
        /// <summary>
        /// 用户Id，多个以逗号分割
        /// </summary>
        [XmlElement("buyer_user_ids")]
        public string BuyerUserIds { get; set; }

        /// <summary>
        /// 业务扩展字段JSON格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [XmlElement("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// UONE问券ID
        /// </summary>
        [XmlElement("rmt_qstn_id")]
        public string RmtQstnId { get; set; }
    }
}
