using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpCommissionDetailQueryResponse.
    /// </summary>
    public class AlipayOpenSpCommissionDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_list")]
        [XmlArrayItem("detail_commission_info")]
        public List<DetailCommissionInfo> CommissionList { get; set; }

        /// <summary>
        /// 抽佣模式
        /// </summary>
        [XmlElement("commission_mode")]
        public string CommissionMode { get; set; }

        /// <summary>
        /// 抽佣场景
        /// </summary>
        [XmlElement("commission_scene")]
        public string CommissionScene { get; set; }

        /// <summary>
        /// 商家确认链接，商家确认阶段才有
        /// </summary>
        [XmlElement("merchant_confirm_url")]
        public string MerchantConfirmUrl { get; set; }

        /// <summary>
        /// 商家 id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户登录号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }
    }
}
