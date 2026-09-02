using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfRecipeinfoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfRecipeinfoSendModel : AopObject
    {
        /// <summary>
        /// 分配给业务方的事件code 
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 调用方自定义，标识自己业务
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 处方内容
        /// </summary>
        [XmlElement("recipeinfo")]
        public RecipeInfo Recipeinfo { get; set; }

        /// <summary>
        /// 业务方请求id，业务方要保证唯一，用于幂等性校验
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
