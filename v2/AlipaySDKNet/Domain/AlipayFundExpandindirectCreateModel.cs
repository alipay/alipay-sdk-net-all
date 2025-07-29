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
        /// 转账场景说明
        /// </summary>
        [XmlElement("scene_directions")]
        public string SceneDirections { get; set; }

        /// <summary>
        /// 转账场景截图，用户拿到转账资金的交互图/贵司系统操作后台截图等。其值为使用alipay.fund.expandindirect.image.upload上传图片得到的一串文件 key。多个图片/文件用 , 隔开，最多支持5个图片/文件
        /// </summary>
        [XmlElement("scene_image")]
        public string SceneImage { get; set; }

        /// <summary>
        /// 客户属于以下场景时或为他人代发时请上传行业资质/场景有效凭证。 当scene_code为【佣金报酬】，则需要提供同主体的发薪资质（如人力资源经营许可证、劳务派遣经营许可证、委托代征协议）及至少一份已签署的上游委托发薪企业的合作合同； 如无发薪资质，则应（1）提供付款员工清单并盖章及至少3份已签署的劳动（务）合同；或（2）提供付款员工清单并盖章及有权机关出具的最近一个月代缴个税证明或社保缴纳证明。 当scene_code为【现金营销】，则需要提供用户参与营销活动细则。 当scene_code为【行政补贴】，则需要提供行政补贴/奖励的官方文件或政府官网全文截图；若是行政机关委托其他主体发放补贴/奖励且无官方文件，则需行政机关提供单独的证明函，说明委托关系； 当scene_code为【保险理赔】，则需要提供保险资质证明（如《保险许可证》《保险业务法人登记证书》等）或保司合作证明 当scene_code为【采购货款】，则需要提供至少一份上下游合作伙伴合作协议。 客户如受其他公司委托为他人代发，无论属于什么场景，请上传合作协议，协议需包含甲方行业、委托代发原因、代发对象身份等。其值为使用alipay.fund.expandindirect.image.upload上传图片得到的一串文件 key。多个图片/文件用 , 隔开，最多支持5个图片/文件
        /// </summary>
        [XmlElement("scene_qualification_image")]
        public string SceneQualificationImage { get; set; }

        /// <summary>
        /// 二级商户信息
        /// </summary>
        [XmlElement("secondary_partner_info")]
        public SecondaryPartnerInfo SecondaryPartnerInfo { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序。其值为Map类型的json字符串，其中WEBSITE、APP、GONGZH、QITA、XCHENGXU_ZHI和WEB为Map的key值
        /// </summary>
        [XmlElement("sites")]
        public string Sites { get; set; }
    }
}
