using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentcreateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeAgentcreateQueryModel : AopObject
    {
        /// <summary>
        /// 由开发者创建的外部入驻申请单据号，需与<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.life.agent.create">alipay.open.public.life.agent.create</a>(isv代创建生活号接口)的out_biz_no一致。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
