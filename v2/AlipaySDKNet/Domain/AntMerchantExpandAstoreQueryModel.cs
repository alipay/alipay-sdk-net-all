using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAstoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAstoreQueryModel : AopObject
    {
        /// <summary>
        /// 商家在支付宝平台内创建的一种营销业务的载体，可以支持发品、配券以及活动报名的id,它的来源是SAAS服务商来进件的时候,创建团购店铺的时候,生成的。
        /// </summary>
        [XmlElement("a_store_id")]
        public string AStoreId { get; set; }

        /// <summary>
        /// 外部业务单号,与店铺对应,本期暂时不支持
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
