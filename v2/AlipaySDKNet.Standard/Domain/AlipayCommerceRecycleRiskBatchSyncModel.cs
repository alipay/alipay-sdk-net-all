using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleRiskBatchSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleRiskBatchSyncModel : AopObject
    {
        /// <summary>
        /// 黑名单列表
        /// </summary>
        [XmlArray("black_list")]
        [XmlArrayItem("recycle_black_list")]
        public List<RecycleBlackList> BlackList { get; set; }

        /// <summary>
        /// 下单人支付宝用户id:USER_ID； 取件人手机号:MOBILE； 取件人地址:ADDRESS； 支付宝交易组件订单id:ORDER； 下单人支付宝用户openid:OPEN_ID
        /// </summary>
        [XmlElement("black_list_type")]
        public string BlackListType { get; set; }

        /// <summary>
        /// 服务类目编码
        /// </summary>
        [XmlElement("service_category_code")]
        public string ServiceCategoryCode { get; set; }
    }
}
