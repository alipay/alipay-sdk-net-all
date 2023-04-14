using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRefundModel : AopObject
    {
        /// <summary>
        /// 退款包含的商品列表信息，Json格式。
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要退款的交易所属收单机构的pid;
        /// </summary>
        [XmlElement("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一，如需部分退款，则此参数必传。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。与支付宝交易号 trade_no 不能同时为空。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 查询选项。 商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。支持：refund_detail_item_list：退款使用的资金渠道；deposit_back_info：触发银行卡冲退信息通知；
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 指定垫资退款账号主体，可能是用户id或登录名
        /// </summary>
        [XmlElement("refund_advance_account")]
        public string RefundAdvanceAccount { get; set; }

        /// <summary>
        /// 指定垫资退款账号的类型，取值范围：default，userId，loginName
        /// </summary>
        [XmlElement("refund_advance_account_type")]
        public string RefundAdvanceAccountType { get; set; }

        /// <summary>
        /// 退款金额。 需要退款的金额，该金额不能大于订单金额，单位为元，支持两位小数。 注：如果正向交易使用了营销，该退款金额包含营销金额，支付宝会按业务规则分配营销和买家自有资金分别退多少，默认优先退买家的自有资金。如交易总金额100元，用户支付时使用了80元自有资金和20元无资金流的营销券，商家实际收款80元。如果首次请求退款60元，则60元全部从商家收款资金扣除退回给用户自有资产；如果再请求退款40元，则从商家收款资金扣除20元退回用户资产以及把20元的营销券退回给用户（券是否可再使用取决于券的规则配置）。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 订单退款币种信息。支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [XmlElement("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款包含的商品列表信息
        /// </summary>
        [XmlArray("refund_goods_detail")]
        [XmlArrayItem("refund_goods_detail")]
        public List<RefundGoodsDetail> RefundGoodsDetail { get; set; }

        /// <summary>
        /// 退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息。  注： 1.当面付且非直付通模式无需传入退分账明细，系统自动按退款金额与订单金额的比率，从收款方和分账收入方退款，不支持指定退款金额与退款方。  2.直付通模式，电脑网站支付，手机 APP 支付，手机网站支付产品，须在退款请求中明确是否退分账，从哪个分账收入方退，退多少分账金额；如不明确，默认从收款方退款，收款方余额不足退款失败。不支持系统按比率退款。
        /// </summary>
        [XmlArray("refund_royalty_parameters")]
        [XmlArrayItem("open_api_royalty_detail_info_pojo")]
        public List<OpenApiRoyaltyDetailInfoPojo> RefundRoyaltyParameters { get; set; }

        /// <summary>
        /// 商户门店编号，由商家自定义。需保证当前商户下唯一。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝交易号。 和商户订单号 out_trade_no 不能同时为空。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
