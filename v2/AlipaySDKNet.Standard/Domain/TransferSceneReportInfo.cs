using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferSceneReportInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransferSceneReportInfo : AopObject
    {
        /// <summary>
        /// 转账场景信息描述，即商户所属转账场景下的信息内容。商户可按实际业务场景自定义传参，需严格按照<a href="https://opendocs.alipay.com/open/0iaxid">转账场景信息字段说明</a>传参。<br> 例如：transfer_scene_name为“佣金报酬”且info_type为“佣金报酬说明”时，该值可传入：8月家政服务报酬
        /// </summary>
        [XmlElement("info_content")]
        public string InfoContent { get; set; }

        /// <summary>
        /// 转账场景信息类型，即商户所属转账场景下的信息类型。此字段内容为固定值，需严格按照<a href="https://opendocs.alipay.com/open/0iaxid">转账场景信息字段说明</a>传参。<br> 例如：transfer_scene_name为“佣金报酬”时，该值必须填写取值：佣金报酬说明<br> 注：信息类型不可重复填写，请严格按照示例传入
        /// </summary>
        [XmlElement("info_type")]
        public string InfoType { get; set; }
    }
}
