using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessParams Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessParams : AopObject
    {
        /// <summary>
        /// 实际订单时间，在乘车码场景，传入的是用户刷码乘车时间
        /// </summary>
        [XmlElement("actual_order_time")]
        public string ActualOrderTime { get; set; }

        /// <summary>
        /// 买家备注信息
        /// </summary>
        [XmlElement("buyer_memo")]
        public string BuyerMemo { get; set; }

        /// <summary>
        /// 校园卡编号
        /// </summary>
        [XmlElement("campus_card")]
        public string CampusCard { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 因公付金额。单位：元
        /// </summary>
        [XmlElement("enterprise_pay_amount")]
        public string EnterprisePayAmount { get; set; }

        /// <summary>
        /// 因公付业务信息
        /// </summary>
        [XmlElement("enterprise_pay_info")]
        public string EnterprisePayInfo { get; set; }

        /// <summary>
        /// 收银台强制密码核身参数，实际收银侧会根据这个参数为true并结合业务场景来判断是否密码核身
        /// </summary>
        [XmlElement("force_pwd")]
        public string ForcePwd { get; set; }

        /// <summary>
        /// 商户传入的交易税费。需要落地风控使用
        /// </summary>
        [XmlElement("good_taxes")]
        public string GoodTaxes { get; set; }

        /// <summary>
        /// 商户端创建订单的 IP，须上传正确的用户端外网 IP，支持 ipv4/ipv6 格式； mc_create_trade_ip和mcCreateTradeIp（旧）参数描述相同，首选mc_create_trade_ip入参，请勿重复入参； 如已入参mcCreateTradeIp（旧），无需新增入参mc_create_trade_ip。
        /// </summary>
        [XmlElement("mc_create_trade_ip")]
        public string McCreateTradeIp { get; set; }

        /// <summary>
        /// 信用预授权转交易阶段，优先解冻的用户资产 CREDIT_ASSET：信用资产 COMMON_ASSET：自有资金资产 默认优先解冻资金资产
        /// </summary>
        [XmlElement("priority_unfreeze_asset")]
        public string PriorityUnfreezeAsset { get; set; }

        /// <summary>
        /// 当需要在 商家平台（b.alipay.com）—数据中心 中查看对应业务场景下的数据明细可以通过该参数传入 支持传入的值：<a target="_blank" href="https://opendocs.alipay.com/mini/08by8k?pathHash=96e03412">小程序细分业务场景</a>
        /// </summary>
        [XmlElement("tiny_app_merchant_biz_type")]
        public string TinyAppMerchantBizType { get; set; }
    }
}
