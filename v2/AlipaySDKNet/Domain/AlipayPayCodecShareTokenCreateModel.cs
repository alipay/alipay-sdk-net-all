using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayCodecShareTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayCodecShareTokenCreateModel : AopObject
    {
        /// <summary>
        /// 业务标识，类似于业务主键，诸如pid、uid、门店id 用于幂等标识
        /// </summary>
        [XmlElement("biz_linked_id")]
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 吱口令的业务类型，新增业务请联系吱口令PD分配
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 吱口令解码面板上的右下方按钮文案
        /// </summary>
        [XmlElement("btn_right")]
        public string BtnRight { get; set; }

        /// <summary>
        /// 吱口令解码面板上右下方按钮的链接、一般是活动页面或业务跳转地址,注意该地址必须是小程序地址, 格式为:alipays://platformapi/startapp?appId=开头
        /// </summary>
        [XmlElement("btn_right_href")]
        public string BtnRightHref { get; set; }

        /// <summary>
        /// 展示在吱口令解码的面板上的描述文案
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片地址: 建议在支付宝文件上传接口的图片地址 尺寸：宽高比满足1:1(建议108*108px) 格式：png、jpg 大小：不超过100kb
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 启用时间，如果为空，则默认给接口调用时候系统的当前时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 3600*24（一天）,默认30D，最大值不超过180D
        /// </summary>
        [XmlElement("timeout")]
        public long Timeout { get; set; }

        /// <summary>
        /// 展示在吱口令解码的面板上的标题字段
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
