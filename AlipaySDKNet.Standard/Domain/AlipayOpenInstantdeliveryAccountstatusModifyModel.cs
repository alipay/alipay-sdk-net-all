using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInstantdeliveryAccountstatusModifyModel : AopObject
    {
        /// <summary>
        /// 要更新的商家账户列表
        /// </summary>
        [XmlArray("logistics_account_infos")]
        [XmlArrayItem("logistics_account_info")]
        public List<LogisticsAccountInfo> LogisticsAccountInfos { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
