using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 优惠券金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户出资，单位为元,精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_contribute")]
        public string MerchantContribute { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他出资，非交易商家，单位为元
        /// </summary>
        [XmlElement("other_contribute")]
        public string OtherContribute { get; set; }

        /// <summary>
        /// 其他出资方明细
        /// </summary>
        [XmlArray("other_contribute_detail")]
        [XmlArrayItem("contribute_detail_info")]
        public List<ContributeDetailInfo> OtherContributeDetail { get; set; }

        /// <summary>
        /// 购买该张券时内部出资的部分（包含支付宝/口碑出资的部分），单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("purchase_ant_contribute")]
        public string PurchaseAntContribute { get; set; }

        /// <summary>
        /// 购买该张券的资金中买家自己出资的部分，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("purchase_buyer_contribute")]
        public string PurchaseBuyerContribute { get; set; }

        /// <summary>
        /// 购买该张券的资金中商户出资的部分，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("purchase_merchant_contribute")]
        public string PurchaseMerchantContribute { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
