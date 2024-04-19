using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsureRecommendCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsureRecommendCheckModel : AopObject
    {
        /// <summary>
        /// 被保人列表
        /// </summary>
        [XmlArray("insureds")]
        [XmlArrayItem("ins_open_user_d_t_o")]
        public List<InsOpenUserDTO> Insureds { get; set; }

        /// <summary>
        /// 外部业务单号，用于幂等，如果不传，系统自动生成
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商表示，蚂蚁保分配
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 推荐用户
        /// </summary>
        [XmlElement("recommend_user")]
        public InsOpenUserDTO RecommendUser { get; set; }

        /// <summary>
        /// 蚂蚁保分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 标记访问的端，客户端渠道 ios / android / pc / wx_applet(wx小程序)
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
