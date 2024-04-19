using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantStoreShopcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantStoreShopcodeCreateModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店类目ID，可通过类目查询接口获取。传入时请传入当前类目的叶子节点ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 地理坐标-纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地理坐标-经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商户支付宝登录ID
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 服务商操作员ID，一般由服务商定义
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门头照图片上传后返回的文件地址，由调用图片上传接口后生成并返回
        /// </summary>
        [XmlElement("shop_front_photo")]
        public string ShopFrontPhoto { get; set; }

        /// <summary>
        /// 支付宝店铺ID。如果在创建门店码之前已经创建好了支付宝店铺，则可传入店铺ID。且如果传入了该字段，则需保证该shop_id归属于merchant_logon_id名下。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 名店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号，可由外部应用生成，由英文、数字组成
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 间联商户PID，当间连服务商调用时为必选参数
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 门店码码值，当前只支持传1个
        /// </summary>
        [XmlArray("tokens")]
        [XmlArrayItem("string")]
        public List<string> Tokens { get; set; }
    }
}
