using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAssetAuthorizeQueryResponse.
    /// </summary>
    public class AlipayCommerceEcAssetAuthorizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 资产类型 枚举值 网商授信:EBE_MYBANK_CREDIT 拉卡拉授信：ENT_LAC_CREDIT
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 剩余可用额度，单位元，精确到分
        /// </summary>
        [XmlElement("available_limit")]
        public string AvailableLimit { get; set; }

        /// <summary>
        /// 授信额度，申请完成时必填，必须为整数
        /// </summary>
        [XmlElement("capital_limit")]
        public string CapitalLimit { get; set; }

        /// <summary>
        /// 额度有效期，格式"yyyy-MM-dd"
        /// </summary>
        [XmlElement("expiration_date")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// 授信申请状态 枚举值 申请中: APPLYING 申请通过: PASSED 申请失败：REJECTED 申请取消：CANCEL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
