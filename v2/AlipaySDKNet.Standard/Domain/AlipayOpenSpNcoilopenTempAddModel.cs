using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTempAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenTempAddModel : AopObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address_info_map")]
        public NcoilopenAddressInfo AddressInfoMap { get; set; }

        /// <summary>
        /// 碰一下跳转的页面链接，非二维码链接，是否必填依赖模板配置
        /// </summary>
        [XmlElement("coil_link_url")]
        public string CoilLinkUrl { get; set; }

        /// <summary>
        /// 展示在物料上的唯一编号，可为空，若不填，系统将自动分配
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 线圈总数
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
        /// 点位名称，是否必填由模板配置决定
        /// </summary>
        [XmlElement("position_name")]
        public string PositionName { get; set; }

        /// <summary>
        /// 对外展示的二维码链接，是否必填由模板配置决定
        /// </summary>
        [XmlElement("print_qr_code_url")]
        public string PrintQrCodeUrl { get; set; }

        /// <summary>
        /// 流水id，通过调用alipay.open.sp.ncoilopen.reference.create接口返回值中获取reference_id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
