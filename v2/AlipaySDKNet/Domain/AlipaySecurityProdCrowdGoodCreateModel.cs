using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdCrowdGoodCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdCrowdGoodCreateModel : AopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 批次号，用于某一个任务批次的批量操作
        /// </summary>
        [XmlElement("batch_number")]
        public string BatchNumber { get; set; }

        /// <summary>
        /// 业务id，包括POI_ID，PID，SN
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// POI_ID
        /// </summary>
        [XmlElement("business_id_type")]
        public string BusinessIdType { get; set; }

        /// <summary>
        /// 城市编码，上海市：310100
        /// </summary>
        [XmlElement("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 额外参数，json string格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// LEAD：找店
        /// </summary>
        [XmlElement("good_type")]
        public string GoodType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// OFFLINE_OPERATION，线下任务
        /// </summary>
        [XmlElement("operation_mode")]
        public string OperationMode { get; set; }

        /// <summary>
        /// 6位员工号，可留空
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 外部业务 id,幂等控制;不填不校验幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 模板替换字符json string，比如{"shop_name" : "全家便利店"}
        /// </summary>
        [XmlElement("place_holder")]
        public string PlaceHolder { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 任务库存，默认为1，单位是个
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
