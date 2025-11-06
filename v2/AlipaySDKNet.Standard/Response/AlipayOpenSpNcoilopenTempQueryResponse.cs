using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTempQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenTempQueryResponse : AopResponse
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address_info_map")]
        public NcoilopenAddressInfo AddressInfoMap { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 碰一下跳转的页面链接
        /// </summary>
        [XmlElement("coil_link_url")]
        public string CoilLinkUrl { get; set; }

        /// <summary>
        /// 展示在物料上的唯一编号，可为空，若不填，系统将自动分配
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 物料总数，单位：个
        /// </summary>
        [XmlElement("coil_total")]
        public long CoilTotal { get; set; }

        /// <summary>
        /// 桌号/座号/楼栋号/序号，是否填写依赖模版配置
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 扩展属性值，提前和BD确定字段名称，按需填写
        /// </summary>
        [XmlArray("ext_attr_list")]
        [XmlArrayItem("ext_attribute_info")]
        public List<ExtAttributeInfo> ExtAttrList { get; set; }

        /// <summary>
        /// 码组序列：填写后，供应商将同一码组序号的线圈进行分包后发货。支持中文、数字、字母等，若无，可不填
        /// </summary>
        [XmlElement("group_no")]
        public string GroupNo { get; set; }

        /// <summary>
        /// 二维码链接
        /// </summary>
        [XmlElement("print_qr_code_url")]
        public string PrintQrCodeUrl { get; set; }

        /// <summary>
        /// 单条标识id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
