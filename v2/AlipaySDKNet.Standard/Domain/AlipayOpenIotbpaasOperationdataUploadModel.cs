using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasOperationdataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasOperationdataUploadModel : AopObject
    {
        /// <summary>
        /// 日期字符串，格式为yyyyMMdd
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 设备biztid，没有可不传
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 运营数据列表
        /// </summary>
        [XmlArray("operation_data_list")]
        [XmlArrayItem("operation_data")]
        public List<OperationData> OperationDataList { get; set; }

        /// <summary>
        /// 商户PID，直连商户传递
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店唯一编号（可以是商户自定义商户id）
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 直连商户传 PID，间连商户传 SMID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
