using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleMerchantassetSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleMerchantassetSaveModel : AopObject
    {
        /// <summary>
        /// 资金账号，用于指定安全发记账本的充值账号和提现账号，注意返回的sign_url需要用登陆该账号授权。 默认值为调用接口的商户pid。 注意：该字段不可修改。
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔保存请求，商户需保证该订单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// sellerid集合，该字段支持修改，每次修改时需要传入不同的out_biz_no。
        /// </summary>
        [XmlArray("seller_id_list")]
        [XmlArrayItem("string")]
        public List<string> SellerIdList { get; set; }

        /// <summary>
        /// 商户补贴比例 默认10% 值范围是：0～100 注意：该字段不可修改。
        /// </summary>
        [XmlElement("subsidy_ratio")]
        public string SubsidyRatio { get; set; }
    }
}
