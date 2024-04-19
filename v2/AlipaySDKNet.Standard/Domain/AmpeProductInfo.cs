using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeProductInfo : AopObject
    {
        /// <summary>
        /// 类目描述
        /// </summary>
        [XmlElement("category_desc")]
        public string CategoryDesc { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 设备机型列表
        /// </summary>
        [XmlArray("device_model_list")]
        [XmlArrayItem("ampe_device_model_info")]
        public List<AmpeDeviceModelInfo> DeviceModelList { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类型描述
        /// </summary>
        [XmlElement("device_type_desc")]
        public string DeviceTypeDesc { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 调用的appId
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [XmlElement("product_pic")]
        public string ProductPic { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reject_memo")]
        public string RejectMemo { get; set; }

        /// <summary>
        /// 出货量
        /// </summary>
        [XmlElement("ship_quantity")]
        public long ShipQuantity { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 审核状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }
    }
}
