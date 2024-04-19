using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceMessageOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceMessageOrderCreateModel : AopObject
    {
        /// <summary>
        /// 提供预约/取号功能服务路径页面地址，具体请联系支付宝业务经理
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 证件号,须做md5处理后传输,示例中值的明文为310101198011110010.
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 城市编码，具体参考 中华人民共和国民政部行政编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 加密方式
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 办事附加信息
        /// </summary>
        [XmlElement("ext_info")]
        public MsgOrderExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 具体的办事列表
        /// </summary>
        [XmlArray("goods_info_list")]
        [XmlArrayItem("msg_order_goods_info_list")]
        public List<MsgOrderGoodsInfoList> GoodsInfoList { get; set; }

        /// <summary>
        /// 行业编号，具体请联系支付宝业务经理
        /// </summary>
        [XmlElement("industry_id")]
        public string IndustryId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 预约事项办件量
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 格式要求：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 1.订单状态更新时必须更新此时间 2.格式要求：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_update_time")]
        public string OrderUpdateTime { get; set; }

        /// <summary>
        /// 确保办事（预约/取号）业务订单号唯一，但同一次办事业务订单号在不同的状态下不能改变且APPID维度下唯一。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 办件量
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 取号方式
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 业务订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 办事预约/取号的订单详情页链接。
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 模板编号，具体请联系支付宝业务经理
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
