using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeAssetRequest Data Structure.
    /// </summary>
    [Serializable]
    public class TradeAssetRequest : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 资产金额,单位元
        /// </summary>
        [XmlElement("asset_amount")]
        public string AssetAmount { get; set; }

        /// <summary>
        /// 资产类型。具体说明如下： 小程序支付：支付宝小程序内创建订单并支付 APP支付：外部商户APP唤起快捷SDK创建订单并支付。 协议支付：用户与商户签署扣款协议后，商户可通过本接口做后续免密代扣操作。
        /// </summary>
        [XmlElement("asset_code")]
        public string AssetCode { get; set; }

        /// <summary>
        /// 业务透传信息
        /// </summary>
        [XmlElement("portable")]
        public string Portable { get; set; }

        /// <summary>
        /// 支付说明、订单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }
    }
}
