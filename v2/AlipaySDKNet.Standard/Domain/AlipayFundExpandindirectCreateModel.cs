using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundExpandindirectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundExpandindirectCreateModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 原进件单id，当biz_type为MODIFY时，必选
        /// </summary>
        [XmlElement("original_order_id")]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// 外部单号（唯一幂等号），当biz_type为MODIFY时，需要保证和原始的out_biz_no不同
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 资金记账本的业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 转账场景说明，对应的业务场景要求详见<a href="https://opendocs.alipay.com/solution/0j3acx?pathHash=abf6ce36">专用金资金二级商户KYB代进件对客说明文档</a> scene_directions｜转账场景说明
        /// </summary>
        [XmlElement("scene_directions")]
        public string SceneDirections { get; set; }

        /// <summary>
        /// 转账场景截图，用户收到转账资金的账单截图或二级商户系统操作后台截图等。其值为使用alipay.fund.expandindirect.image.upload上传图片得到的一串文件 key。多个图片/文件用 , 隔开，最多支持5个图片/文件
        /// </summary>
        [XmlElement("scene_image")]
        public string SceneImage { get; set; }

        /// <summary>
        /// 根据对应的业务场景要求提供对应的材料，详见<a href="https://opendocs.alipay.com/solution/0j3acx?pathHash=abf6ce36">专用金资金二级商户KYB代进件对客说明文档</a>scene_qualification_image｜商户行业资质图片或协议文本
        /// </summary>
        [XmlElement("scene_qualification_image")]
        public string SceneQualificationImage { get; set; }

        /// <summary>
        /// 二级商户信息
        /// </summary>
        [XmlElement("secondary_partner_info")]
        public SecondaryPartnerInfo SecondaryPartnerInfo { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序。其值为Map类型的json字符串，其中WEBSITE、APP、GONGZH、QITA、XCHENGXU_ZHI和WEB为Map的key值。 根据对应的业务场景要求提供对应的信息，详见<a href="https://opendocs.alipay.com/solution/0j3acx?pathHash=abf6ce36">专用金资金二级商户KYB代进件对客说明文档</a> sites｜商户站点信息（为空代表不用传）
        /// </summary>
        [XmlElement("sites")]
        public string Sites { get; set; }
    }
}
