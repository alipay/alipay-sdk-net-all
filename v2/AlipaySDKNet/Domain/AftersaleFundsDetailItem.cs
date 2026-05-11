using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleFundsDetailItem Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleFundsDetailItem : AopObject
    {
        /// <summary>
        /// 当前售后单上退款资金中的资产项
        /// </summary>
        [XmlElement("asset_code")]
        public string AssetCode { get; set; }

        /// <summary>
        /// 当前售后单中退款资金中某一资产项的名称
        /// </summary>
        [XmlElement("asset_name")]
        public string AssetName { get; set; }

        /// <summary>
        /// 当前售后单中退款资金中某一资产项的具体值，金额单位为元
        /// </summary>
        [XmlElement("asset_value")]
        public string AssetValue { get; set; }
    }
}
