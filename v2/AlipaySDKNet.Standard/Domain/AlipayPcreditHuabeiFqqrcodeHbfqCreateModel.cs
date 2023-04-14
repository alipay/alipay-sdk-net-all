using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiFqqrcodeHbfqCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiFqqrcodeHbfqCreateModel : AopObject
    {
        /// <summary>
        /// 用于物流派送的收件详细地址.
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区编码,用于物流派送的收件地址.地址库版本LBS:2020Q1.例如320102表示江苏省南京市玄武区,则本字段传02.
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 市编码,用于物流派送的收件地址.地址库版本LBS:2020Q1.例如320100表示江苏省南京市,则本字段传01
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户申请的码类型.码类型分为主扫和被扫.0表示被扫,1表示主扫.如果要申请主扫码,则本字段传1;如果要申请被扫码,本字段传0.
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 扩展字段,用于满足一些定制化的申请码需求.
        /// </summary>
        [XmlElement("fqqr_code_ext_info")]
        public FqQrCodeExtendParams FqqrCodeExtInfo { get; set; }

        /// <summary>
        /// 商户申请的物料样式.例如:0代表立牌,1代表贴纸.如果要申请立牌码的话,本字段传0.
        /// </summary>
        [XmlElement("materials")]
        public string Materials { get; set; }

        /// <summary>
        /// 收件人姓名.申请成功后,会给商户邮寄实体码,需要给物流放提供收件信息.
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部请求号,用于唯一标识一次请求.仅可以由英文字母和数字组成.需要保证在服务商端不重复.
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 省份编码,用于物流派送的收件地址.地址库版本:LBS:2020Q1.例如:320000表示江苏省,则本字段传32.
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 商家本次请求希望申请的物料数量.
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 二级商户唯一标识
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 服务商唯一标识
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 商店唯一标识,可以为空.
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 街道编码,用于物流派送的收件地址.地址库版本LBS:2020Q1.例如320102003表示江苏省南京市玄武区新街口街道,则本字段传003.
        /// </summary>
        [XmlElement("street_code")]
        public string StreetCode { get; set; }

        /// <summary>
        /// 收件人联系方式,手机号.用于物流派送时联系收件人.
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
