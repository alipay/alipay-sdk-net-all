using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionDevicegrayModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionDevicegrayModifyModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入，申请方式请参见接入手册。
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 设备号列表
        /// </summary>
        [XmlArray("device_no_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceNoList { get; set; }

        /// <summary>
        /// 灰度规则
        /// </summary>
        [XmlElement("gray_code")]
        public string GrayCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
