using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingSharetokenCreateResponse.
    /// </summary>
    public class AlipayMarketingSharetokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 吱口令失效时间，若为空则表示永久有效
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 吱口令引导文案一，示例值中的：『#吱口令# 长按复制此条消息即可分享，』
        /// </summary>
        [XmlElement("guider_str_1")]
        public string GuiderStr1 { get; set; }

        /// <summary>
        /// 吱口令引导文案二，示例值中的：『，赶紧去分享吧』
        /// </summary>
        [XmlElement("guider_str_2")]
        public string GuiderStr2 { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [XmlElement("share_token")]
        public string ShareToken { get; set; }

        /// <summary>
        /// 吱口令生效时间
        /// </summary>
        [XmlArray("start_date")]
        [XmlArrayItem("date")]
        public List<string> StartDate { get; set; }
    }
}
