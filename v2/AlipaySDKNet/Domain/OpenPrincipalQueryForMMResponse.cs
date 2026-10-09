using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenPrincipalQueryForMMResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPrincipalQueryForMMResponse : AopObject
    {
        /// <summary>
        /// 商家扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public AlimamaPrincipalExtendInfo ExtendInfo { get; set; }

        /// <summary>
        /// 灯火一级类目id
        /// </summary>
        [XmlElement("first_trade_id")]
        public string FirstTradeId { get; set; }

        /// <summary>
        /// 投放端商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("principal_oid")]
        public string PrincipalOid { get; set; }

        /// <summary>
        /// 商家对外唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 灯火二级类目id
        /// </summary>
        [XmlElement("second_trade_id")]
        public string SecondTradeId { get; set; }

        /// <summary>
        /// 商家状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商家状态名称
        /// </summary>
        [XmlElement("status_name")]
        public string StatusName { get; set; }
    }
}
