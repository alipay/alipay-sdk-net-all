using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAstoreModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAstoreModifyModel : AopObject
    {
        /// <summary>
        /// 商家在支付宝平台内创建的一种营销业务的载体，可以支持发品、配券以及活动报名的id,它的来源是SAAS服务商来进件的时候,创建团购店铺的时候,生成的。
        /// </summary>
        [XmlElement("a_store_id")]
        public string AStoreId { get; set; }

        /// <summary>
        /// 联系手机号(示例值是示范,正常填写不需要掩码)
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 结算信息
        /// </summary>
        [XmlElement("settle_infos")]
        public SettleInfoModel SettleInfos { get; set; }
    }
}
