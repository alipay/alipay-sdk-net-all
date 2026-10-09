using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectSharetokenCreateResponse.
    /// </summary>
    public class AlipayMerchantIndirectSharetokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务token,用来串联业务操作行为及分析
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 吱口令失效时间，若为空则表示永久有效
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 吱口令分析引导文案前半段，即示例值中吱口令码值的前一句文案【#吱口令# 长按复制此条消息即可分享，】
        /// </summary>
        [XmlElement("guide_text_1")]
        public string GuideText1 { get; set; }

        /// <summary>
        /// 吱口令分析引导文案后半段，即示例值中吱口令码值的后一句文案【，赶紧去分享吧】
        /// </summary>
        [XmlElement("guide_text_2")]
        public string GuideText2 { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [XmlElement("share_token")]
        public string ShareToken { get; set; }
    }
}
