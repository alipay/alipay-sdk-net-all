using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 业务扩展ID，关联外部业务数据ID
        /// </summary>
        [XmlElement("biz_ext_id")]
        public string BizExtId { get; set; }

        /// <summary>
        /// 预留业务扩展字段
        /// </summary>
        [XmlElement("biz_ext_info")]
        public string BizExtInfo { get; set; }

        /// <summary>
        /// 业务扩展类型
        /// </summary>
        [XmlElement("biz_ext_type")]
        public string BizExtType { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 查询业务场景大类
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 提交单号-入参指定提交号，则会进行操作校验，用户之前是否有操作流水，Y-返回当前入参指定提交号，N-异常终止
        /// </summary>
        [XmlElement("submit_no")]
        public string SubmitNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
