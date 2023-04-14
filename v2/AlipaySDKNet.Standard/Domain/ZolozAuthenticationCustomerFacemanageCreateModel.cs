using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFacemanageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerFacemanageCreateModel : AopObject
    {
        /// <summary>
        /// 地域编码
        /// </summary>
        [XmlElement("areacode")]
        public string Areacode { get; set; }

        /// <summary>
        /// 人脸产品能力，预热场景，需要传college，k12，scenic，subway，traffic。具体值视具体场景
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务量规模
        /// </summary>
        [XmlElement("bizscale")]
        public string Bizscale { get; set; }

        /// <summary>
        /// 商户品牌
        /// </summary>
        [XmlElement("brandcode")]
        public string Brandcode { get; set; }

        /// <summary>
        /// 商户机具唯一编码，关键参数 人脸预热，传logicGroupId
        /// </summary>
        [XmlElement("devicenum")]
        public string Devicenum { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// 入库类型 IDCARD:身份证 ALIPAY_USER:支付宝用户id, ALIPAY_TEL:手机号入库 CUSTOMER:自定义 DIRECT_CLIENT_PRE：本地预写入 DIRECT_CLIENT：本地客户端库 ENCLOSED：封闭场景
        /// </summary>
        [XmlElement("facetype")]
        public string Facetype { get; set; }

        /// <summary>
        /// 入库用户信息 人脸预热，alipayUid必填
        /// </summary>
        [XmlElement("faceval")]
        public string Faceval { get; set; }

        /// <summary>
        /// 分组5
        /// </summary>
        [XmlElement("group")]
        public string Group { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("storecode")]
        public string Storecode { get; set; }

        /// <summary>
        /// 有效期天数，如7天、30天、365天
        /// </summary>
        [XmlElement("validtimes")]
        public string Validtimes { get; set; }
    }
}
