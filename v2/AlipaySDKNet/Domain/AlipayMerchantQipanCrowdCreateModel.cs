using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档 <a href="https://opendocs.alipay.com/pre-open/04phhq" target="_blank">安全应用范围枚举</a> <br> 未传值或传入渠道均非法时 采用默认渠道，默认渠道：支付结果页AA、繁星激励。<br> 传入值时，以商户入参为准。
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 支付宝人群描述
        /// </summary>
        [XmlElement("crowd_desc")]
        public string CrowdDesc { get; set; }

        /// <summary>
        /// 人群名称 最大长度为15个字符
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 商户外部用户人群code 用于标识商家人群，需保证同一商户下crowd_code唯一
        /// </summary>
        [XmlElement("external_crowd_code")]
        public string ExternalCrowdCode { get; set; }

        /// <summary>
        /// 人群在支付宝棋盘站点是否可见,取值如下： <li>true-支付宝站点<b>不可见</b></li> <li>false-支付宝站点<b>可见，默认值</b></li> 使用说明：创建的人群后续需使用标签进行二次圈选，且本人群对商户不可见时可设置为true。
        /// </summary>
        [XmlElement("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// 人群包含的用户列表 单次上传用户数上限为1000，若用户量过大可分批通过alipay.merchant.qipan.crowduser.add接口上传
        /// </summary>
        [XmlArray("user_list")]
        [XmlArrayItem("qipan_merchant_crowd_user")]
        public List<QipanMerchantCrowdUser> UserList { get; set; }
    }
}
