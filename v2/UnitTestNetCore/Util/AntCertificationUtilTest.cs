﻿using NUnit.Framework;
using Aop.Api.Util;
using System.IO;
using Org.BouncyCastle.X509;

namespace Test
{
    [TestFixture()]
    public class AntCertificationUtilTest
    {
        private const string RsaClientCert = "-----BEGIN CERTIFICATE-----\n"
            + "MIIDQTCCAimgAwIBAgIIBL4R3ybcax0wDQYJKoZIhvcNAQELBQAwGDEWMBQGA1UE\n"
            + "AwwNdGVzdF9yb290X3JzYTAeFw0xOTA5MTYxNDE3MDBaFw0yMDA5MTYxNDExMDBa\n"
            + "MIGZMSAwHgYJKoZIhvcNAQkBFhF6dzIwNzVAYWxpcGF5LmNvbTELMAkGA1UEBhMC\n"
            + "Q04xDzANBgNVBAsTBnNoYW5odTEbMBkGA1UEChMSQWxpcGF5LmNvbSBDby4sTHRk\n"
            + "MREwDwYDVQQIEwhaSEVKSUFORzERMA8GA1UEBxMISEFOR1pIT1UxFDASBgNVBAMT\n"
            + "Cy5hbGlwYXkuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApZRp\n"
            + "YBUsrX5ZLUDlf56ZEHgYpduVKIciKFZkcC3QCvbhnAppM2cK8JJbdd0BlhYf2szy\n"
            + "cqF6DjNJjX3UsFz8Iu7m8AZRpF0MuMikyHROK7aZJBiy4bIpo99ZQIEBHBz3dQfd\n"
            + "idOYjVleW5fQzVnNPDBxFjyP5lT0t+L139IAuzOvIULM6GmvSht9aCd3VKTgw3z9\n"
            + "wq023AbKjQPjw0kBl99zNSpoTSr3wOn/mx142h/npfg/ZrU3+U0wRY/qTtA80J3s\n"
            + "RxTmNJyiWcYJGjZaI62wgMmc5DBrXU9rXE1yO37HTi8sXwwR0yGVW2ZDndEN9wj2\n"
            + "78iKqxIucjI+GO80DQIDAQABow0wCzAJBgNVHRMEAjAAMA0GCSqGSIb3DQEBCwUA\n"
            + "A4IBAQAWeRg3Odw5APWjhWT3jVStSBWE50nie6CCFcCLqmOSaBcad/pE0tx9CyYM\n"
            + "ZGcYbexjQSWp4nsj7JlGsfow27uGDohf0RXOTV9m2g3hVAqqlvwLY0VdfOp7OncC\n"
            + "xxEL6K4DBm1+Aro0LZHGK0G0gqXOwo4a2Ak7QJaGO9FF4Axmnx6BQDVPfyJ0BrB8\n"
            + "ZidNMICVyTRbUp+sq2bOMBs1XVwedzEbESBGiQxrzEBEUBlxozFu5dYkopBqUAWH\n"
            + "QKktaVYRisZMFKxivQRcJ+jYNxcyQCR8bhcp19DQ02hbKCI4vcSgBa8MpvhLSNN4\n"
            + "9GuPU8CL0++tEZ7C00m0HfN1idVK\n"
            + "-----END CERTIFICATE-----";


        private const string RsaClientCertchain = "-----BEGIN CERTIFICATE-----\n"
            + "MIIDozCCAougAwIBAgIBAjANBgkqhkiG9w0BAQsFADCBhjELMAkGA1UEBhMCY24x\n"
            + "ETAPBgNVBAgTCHpoZWppYW5nMREwDwYDVQQHEwhoYW5nemhvdTEPMA0GA1UEChMG\n"
            + "YWxpcGF5MREwDwYDVQQLEwhzZWN1cml0eTETMBEGA1UEAxMKYWxpcGF5LmNvbTEY\n"
            + "MBYGCSqGSIb3DQEJARYJMTFAcXEuY29tMB4XDTE5MDcxMDA2MTgwMFoXDTIwMDcx\n"
            + "MDA2MTgwMFowgYMxCzAJBgNVBAYTAmNuMREwDwYDVQQIEwh6aGVqaWFuZzERMA8G\n"
            + "A1UEBxMIaGFuZ3pob3UxDzANBgNVBAoTBmFsaXBheTERMA8GA1UECxMIc2VjdXJp\n"
            + "dHkxEDAOBgNVBAMTB3NlYy5jb20xGDAWBgkqhkiG9w0BCQEWCTIyQHFxLmNvbTCC\n"
            + "ASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAJyxQuk11jwSYp3tybkXsXrh\n"
            + "+Rm6Yd6sWhl07+pp+sys0tbS2uGh5gB+O1P/zcNqIUwsE7NdCvwYSopLHBN4+BlO\n"
            + "8BE7SP9PN8npadsIHS5nDY/EKCsOQxi1DGhDxJlPn3HqP6/qT0COd8s8Q6k3F1mp\n"
            + "00XHUzmm0NpsXJwX/4a4zOfzHJTt56492bUJZgxQq7zjLegJLFI07mgcSgZhf2D/\n"
            + "GqVx1ep2OJcDovfov/nQ+vJu76WLJgLgaTQ9dLMaToPnLSbX5FZg6Obwd+kyaOjk\n"
            + "afrALQX0oyaomapIbGc3SXVil1uiLzKCLXKTXgoBNkBe5XqBZv62y4P591Y6NJ0C\n"
            + "AwEAAaMdMBswDAYDVR0TBAUwAwEB/zALBgNVHQ8EBAMCAgQwDQYJKoZIhvcNAQEL\n"
            + "BQADggEBADLjYdSW9qr8zu/9AowomKUW0mvxhECziA8jj4OAGTUgJK2apMjlBM5Q\n"
            + "0zcaverN4TGOJpt++E5SxM5/oXSSG4I4WlYUOx5YWvK6EytILD5rZi7B6YmhreiK\n"
            + "hf5YiNfUm7wnycDRbH9aGOPvtOj1habSJAXtGaENLOCe6SCBchBdB2F4w6BsQzZQ\n"
            + "HFwcYdf3icnHmOY5eEDxQALvWnhuYimIcVDlCPUDvj/vkBC0fxyTFe5x6CnY9FoE\n"
            + "C/CQEH98FH3uMrizpN21dX8uZXfxaE1F98gqymJ+tjumE8KoXytQegXZa7A+5nPt\n"
            + "DEuit0muefk7koZiKf0/RFxsfDCJ2Vc=\n"
            + "-----END CERTIFICATE-----\n"
            + "-----BEGIN CERTIFICATE-----\n"
            + "MIIDgzCCAmugAwIBAgIBAzANBgkqhkiG9w0BAQsFADCBgzELMAkGA1UEBhMCY24x\n"
            + "ETAPBgNVBAgTCHpoZWppYW5nMREwDwYDVQQHEwhoYW5nemhvdTEPMA0GA1UEChMG\n"
            + "YWxpcGF5MREwDwYDVQQLEwhzZWN1cml0eTEQMA4GA1UEAxMHc2VjLmNvbTEYMBYG\n"
            + "CSqGSIb3DQEJARYJMjJAcXEuY29tMB4XDTE5MDcxMDA2MjAwMFoXDTIwMDcxMDA2\n"
            + "MTgwMFowdzELMAkGA1UEBhMCY24xEDAOBgNVBAgTB2JlaWppbmcxEDAOBgNVBAcT\n"
            + "B2JlaWppbmcxDTALBgNVBAoTBHNob3AxDjAMBgNVBAsTBWNzaG9wMQwwCgYDVQQD\n"
            + "EwNybHAxFzAVBgkqhkiG9w0BCQEWCDMzQHFxY29tMIIBIjANBgkqhkiG9w0BAQEF\n"
            + "AAOCAQ8AMIIBCgKCAQEAwb8asO4hw4stpERXF752YTmN58wNz5nut5uDFQ89gXub\n"
            + "CIEDoWXuYlUOy9j5Ol0ZeNuwH07qM9YGZt47q8NZMlsOsjmAoYLlrSMtmQPiGNSe\n"
            + "rEINMes350Q4xV+1z9rWlzqUT0kvioGw2zu6yS7rUFN6VjHmQwuqnBzFIAsXhcH6\n"
            + "Tkvw0O0kzeNpYZ/aizCVBGwEmBEY5K/nl5tTlfs2/YGQKjT5PDMMeYaFIX1KZ+2a\n"
            + "9Me03VncBwIA2lAMt8xwyp1sR4RPqXVn56h94HjKOI03TLKqY/35+5y5m6ianyHm\n"
            + "rdOTQdiUH4UwtqXwTAbAVl3sIWYl4T6LcUfFU0dSBQIDAQABow0wCzAJBgNVHRME\n"
            + "AjAAMA0GCSqGSIb3DQEBCwUAA4IBAQAg3Eo0XmyvElapYwF99llLjpd+7RWRNnCs\n"
            + "F9Sk3XHLMZfBmRpO5uMlSNYh2EU30iBbnWLQ1xoerw3qPt8GXI5SP3SY/+BPJJni\n"
            + "4Pv7paXKZfjD/1RrvF5s5akxMgEf0vqWmneg+1wLAeXHal+QCuS89Xb7n05WMHJC\n"
            + "lmAluPRnFfyTuAocJFmLJ7XmnwY0rVUkAazD43w7HlCnfzlJ9OrsnN5zvYPeRTxp\n"
            + "NwBXIimtKFKsVBtfNbZjl43qRfdE4rVdkwSPMtxLxmTq8AlF0i2jUHJ5XnOpnAye\n"
            + "PP2ojgQz3S6hnLs2UjYD+2rRF60c8g+GFYHcEICAfT9pU77YAk4h\n"
            + "-----END CERTIFICATE-----\n"
            + "-----BEGIN CERTIFICATE-----\n"
            + "MIIDpjCCAo6gAwIBAgIBATANBgkqhkiG9w0BAQsFADCBhjELMAkGA1UEBhMCY24x\n"
            + "ETAPBgNVBAgTCHpoZWppYW5nMREwDwYDVQQHEwhoYW5nemhvdTEPMA0GA1UEChMG\n"
            + "YWxpcGF5MREwDwYDVQQLEwhzZWN1cml0eTETMBEGA1UEAxMKYWxpcGF5LmNvbTEY\n"
            + "MBYGCSqGSIb3DQEJARYJMTFAcXEuY29tMB4XDTE5MDcxMDA2MTEwMFoXDTIwMDcy\n"
            + "MzA2MTEwMFowgYYxCzAJBgNVBAYTAmNuMREwDwYDVQQIEwh6aGVqaWFuZzERMA8G\n"
            + "A1UEBxMIaGFuZ3pob3UxDzANBgNVBAoTBmFsaXBheTERMA8GA1UECxMIc2VjdXJp\n"
            + "dHkxEzARBgNVBAMTCmFsaXBheS5jb20xGDAWBgkqhkiG9w0BCQEWCTExQHFxLmNv\n"
            + "bTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAJJ/4n7xQ3swPKFbju7d\n"
            + "U8OSbgeE2U4SRS1iuL+wn2hJIFMd5pfLJ418IBZAgLkPdKZacrPli4sZ/H1liGCh\n"
            + "tGvSTM8Gj3t5mr6b2yXE/0F8DZHasnmYUnR1k50zNjFDVS6By84/AwKWY/NHH4sX\n"
            + "7FNrU2ojvw038jmXq3qy6tymErU1hY/3t7E7gB5b+v+yHTvwk/2igNq8c8v6xHpu\n"
            + "n94me/QxNnZufvXJmEPR9TezFjE3+VyDOIapge2/2ewhYO7uWQMPtBQ+SAX00ZOs\n"
            + "V7nEehmwN5vlBD/RnHpnuJFquiFowueABu+8UbdoOrVnZDUQzBwXFxEHdJjVECVm\n"
            + "kLECAwEAAaMdMBswDAYDVR0TBAUwAwEB/zALBgNVHQ8EBAMCAgQwDQYJKoZIhvcN\n"
            + "AQELBQADggEBACcFeQXW5wfke9c1Bq8umtCjXdlsCfXX73tTCW2psFGdWj4QFvYB\n"
            + "U8b1xGsTLR6r05J7MpcOuiQJInpOlPPdoqRjpnIvGwE1hH+rzmMuySBRAnm/5YNg\n"
            + "EZjalf7v+lYwpDnSis+mZzF8ZeK8GknKM7AQPNcthgojn9HKF0EYf+CIyMXEPcI8\n"
            + "vzUjneejRMGnu5WS4QMbDUS+KAu/HNGclrrt4Jfoez35tdRj7xlhkIk1edCGG+3a\n"
            + "8eMA7LHCr+GQPn6XwbVv8SmHahYAkHA6+WNnHRGJbLU9D903CfnbzPP79FU2bker\n"
            + "aPQkmBhRJKiLqiwoso/kKiAsBaOS26FUvFU=\n"
            + "-----END CERTIFICATE-----";

        private const string RsaRootCa = "-----BEGIN CERTIFICATE-----\n"
                + "MIICwjCCAaqgAwIBAgIIU6T3Abo/1b8wDQYJKoZIhvcNAQELBQAwGDEWMBQGA1UE\n"
                + "AwwNdGVzdF9yb290X3JzYTAeFw0xOTA5MTYxNDExMDBaFw0yMDA5MTYxNDExMDBa\n"
                + "MBgxFjAUBgNVBAMMDXRlc3Rfcm9vdF9yc2EwggEiMA0GCSqGSIb3DQEBAQUAA4IB\n"
                + "DwAwggEKAoIBAQDBgawQuUkq64ILYNHk5pRBePWfjdcfDv+c9qSX+HvbRw9bM4MI\n"
                + "n9V2FUGbxbuhiaEF9Iu2lX4Z8zgW4KBsm50klH5jv4aTMVpTGEFzURXUKm7yDGFf\n"
                + "bzg4K1A53IZ+5NM+XcDLd8jqlWFb7lMm3pkGhRBFp1+90qBf9OpqBXIbqFqoYVVZ\n"
                + "hu3rKpFgBUwE3E1dGA+eG4Nl+jaLsvn/Ug5QVBbgb5xfmTpum8tDOIH/wPIi3B7l\n"
                + "4QxNzhW1F/KwbGcPQ88Nxycsv460vpSwDMvl3Dy80DDgD1CyhcViVakXn6hRH5mM\n"
                + "tC5CdRFs6oTUs4QSPdOaSODcS3ef3vh5A6ALAgMBAAGjEDAOMAwGA1UdEwQFMAMB\n"
                + "Af8wDQYJKoZIhvcNAQELBQADggEBAIInR/okDSqnsd1ITA6aOgP9Azb5ym24xWdJ\n"
                + "rqTuUh1JXyUJ5QzhKfq3SCWCK1BhIrG6OTdYH9L1aUlnqcQIlyzb2gfMp46F+pKf\n"
                + "aVLbhI4phZJrcLqJGBOuVOq4c41zpZTKLNL2oIiuq8BM1Jkg/DbqiUo/eg1wQb5N\n"
                + "19xebsUizyaC6PSmbSMxGM3uksRAzHUt7T8r/FLzidsELZp6E5mKITSKLarw2+FZ\n"
                + "dEtJ8y3ZdEYKxfJt2ZHLlLGYFcgtJB78bkNU+Jg1KPzceqcBZbLugImFuJeX++4d\n"
                + "9+A5Ok9ULlBCQO6QOS3OIs69ireQHt93ZHp83OtN2/4w1EPoXrk=\n"
                + "-----END CERTIFICATE-----";

        private const string BadSignRsaClientCert = "-----BEGIN CERTIFICATE-----\n"
                + "MIIDQTCCAimgAwIBAgIIBL4R3ybcax0wDQYJKoZIhvcNAQELBQAwGDEWMBQGA1UE\n"
                + "AwwNdGVzdF9yb290X3JzYTAeFw0xOTA5MTYxNDE3MDBaFw0yMDA5MTYxNDExMDBa\n"
                + "MIGZMSAwHgYJKoZIhvcNAQkBFhF6dzIwNzVAYWxpcGF5LmNvbTELMAkGA1UEBhMC\n"
                + "Q04xDzANBgNVBAsTBnNoYW5odTEbMBkGA1UEChMSQWxpcGF5LmNvbSBDby4sTHRk\n"
                + "MREwDwYDVQQIEwhaSEVKSUFORzERMA8GA1UEBxMISEFOR1pIT1UxFDASBgNVBAMT\n"
                + "Cy5hbGlwYXkuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApZRp\n"
                + "YBUsrX5ZLUDlf56ZEHgYpduVKIciKFZkcC3QCvbhnAppM2cK8JJbdd0BlhYf2szy\n"
                + "cqF6DjNJjX3UsFz8Iu7m8AZRpF0MuMikyHROK7aZJBiy4bIpo99ZQIEBHBz3dQfd\n"
                + "idOYjVleW5fQzVnNPDBxFjyP5lT0t+L139IAuzOvIULM6GmvSht9aCd3VKTgw3z9\n"
                + "wq023AbKjQPjw0kBl99zNSpoTSr3wOn/mx142h/npfg/ZrU3+U0wRY/qTtA80J3s\n"
                + "RxTmNJyiWcYJGjZaI62wgMmc5DBrXU9rXE1yO37HTi8sXwwR0yGVW2ZDndEN9wj2\n"
                + "78iKqxIucjI+GO80DQIDAQABow0wCzAJBgNVHRMEAjAAMA0GCSqGSIb3DQEBCwUA\n"
                + "A4IBAQAWeRg3Odw5APWjhWT3jVStSBWE50nie6CCFcCLqmOSaBcad/pE0tx9CyYM\n"
                + "ZGcYbexjQSWp4nsj7JlGsfow27uGDohf0RXOTV9m2g3hVAqqlvwLY0VdfOp7OncC\n"
                + "xxEL6K4DBm1+Aro0LZHGK0G0gqXOwo4a2Ak7QJaGO9FF4Axmnx6BQDVPfyJ0BrB8\n"
                + "ZidNMICVyTRbUp+sq2bOMBs1XVwedzEbESBGiQxrzEBEUBlxozFu5dYkopBqUAWH\n"
                + "QKktaVYRisZMFKxivQRcJ+jYNxcyQCR8bhcp19DQ02hbKCI4vcSgBa8MpvhLSNN4\n"
                + "9GuPU8CL0++tEZ7C00m0HfN1idVV\n"
                + "-----END CERTIFICATE-----";

        private const string BadDateRsaClientCert = "-----BEGIN CERTIFICATE-----\n"
                + "MIIDQTCCAimgAwIBAgIIYDk+SNIzF9kwDQYJKoZIhvcNAQELBQAwGDEWMBQGA1UE\n"
                + "AwwNdGVzdF9yb290X3JzYTAeFw0xOTA5MTYxNDExMDBaFw0xOTA5MTYxNDExMDBa\n"
                + "MIGZMSAwHgYJKoZIhvcNAQkBFhF6dzIwNzVAYWxpcGF5LmNvbTELMAkGA1UEBhMC\n"
                + "Q04xDzANBgNVBAsTBnNoYW5odTEbMBkGA1UEChMSQWxpcGF5LmNvbSBDby4sTHRk\n"
                + "MREwDwYDVQQIEwhaSEVKSUFORzERMA8GA1UEBxMISEFOR1pIT1UxFDASBgNVBAMT\n"
                + "Cy5hbGlwYXkuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApZRp\n"
                + "YBUsrX5ZLUDlf56ZEHgYpduVKIciKFZkcC3QCvbhnAppM2cK8JJbdd0BlhYf2szy\n"
                + "cqF6DjNJjX3UsFz8Iu7m8AZRpF0MuMikyHROK7aZJBiy4bIpo99ZQIEBHBz3dQfd\n"
                + "idOYjVleW5fQzVnNPDBxFjyP5lT0t+L139IAuzOvIULM6GmvSht9aCd3VKTgw3z9\n"
                + "wq023AbKjQPjw0kBl99zNSpoTSr3wOn/mx142h/npfg/ZrU3+U0wRY/qTtA80J3s\n"
                + "RxTmNJyiWcYJGjZaI62wgMmc5DBrXU9rXE1yO37HTi8sXwwR0yGVW2ZDndEN9wj2\n"
                + "78iKqxIucjI+GO80DQIDAQABow0wCzAJBgNVHRMEAjAAMA0GCSqGSIb3DQEBCwUA\n"
                + "A4IBAQCdu7xG7JLLDfxh4PDvb/0zvYuA/v6Mt4lojlg0TIyDVwWwI/nly6Sg1g7t\n"
                + "Qyf/RY63tiG6gkVk2cOEOluUya9+9cgutGZ4iBSegSZ0CQ3atR3koUWcPsMEz98j\n"
                + "rmJH9QgUO0A4cSe8fe0lOSbErXQd12A7eVpUkOEyeoh0jQ+elGwiNjzCOKuql0gb\n"
                + "sRREFqQuRmhvIEr88cBOvQgwnkguz8rq1K335lmBAvi0iqaa93FwvhsaYPTNxnyN\n"
                + "0jD8cV9H743RcXssQoT/iNK8x2LLrd2DXMea4AzxEkLDXEHRNBcVbTfW5vLdy2ac\n"
                + "JgU9bAa97HqWJvlc2icc0KKibQ/r\n"
                + "-----END CERTIFICATE-----";

        private const string RsaRootCaChain = "-----BEGIN CERTIFICATE-----\n"
            + "MIIDpjCCAo6gAwIBAgIBATANBgkqhkiG9w0BAQsFADCBhjELMAkGA1UEBhMCY24x\n"
            + "ETAPBgNVBAgTCHpoZWppYW5nMREwDwYDVQQHEwhoYW5nemhvdTEPMA0GA1UEChMG\n"
            + "YWxpcGF5MREwDwYDVQQLEwhzZWN1cml0eTETMBEGA1UEAxMKYWxpcGF5LmNvbTEY\n"
            + "MBYGCSqGSIb3DQEJARYJMTFAcXEuY29tMB4XDTE5MDcxMDA2MTEwMFoXDTIwMDcy\n"
            + "MzA2MTEwMFowgYYxCzAJBgNVBAYTAmNuMREwDwYDVQQIEwh6aGVqaWFuZzERMA8G\n"
            + "A1UEBxMIaGFuZ3pob3UxDzANBgNVBAoTBmFsaXBheTERMA8GA1UECxMIc2VjdXJp\n"
            + "dHkxEzARBgNVBAMTCmFsaXBheS5jb20xGDAWBgkqhkiG9w0BCQEWCTExQHFxLmNv\n"
            + "bTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAJJ/4n7xQ3swPKFbju7d\n"
            + "U8OSbgeE2U4SRS1iuL+wn2hJIFMd5pfLJ418IBZAgLkPdKZacrPli4sZ/H1liGCh\n"
            + "tGvSTM8Gj3t5mr6b2yXE/0F8DZHasnmYUnR1k50zNjFDVS6By84/AwKWY/NHH4sX\n"
            + "7FNrU2ojvw038jmXq3qy6tymErU1hY/3t7E7gB5b+v+yHTvwk/2igNq8c8v6xHpu\n"
            + "n94me/QxNnZufvXJmEPR9TezFjE3+VyDOIapge2/2ewhYO7uWQMPtBQ+SAX00ZOs\n"
            + "V7nEehmwN5vlBD/RnHpnuJFquiFowueABu+8UbdoOrVnZDUQzBwXFxEHdJjVECVm\n"
            + "kLECAwEAAaMdMBswDAYDVR0TBAUwAwEB/zALBgNVHQ8EBAMCAgQwDQYJKoZIhvcN\n"
            + "AQELBQADggEBACcFeQXW5wfke9c1Bq8umtCjXdlsCfXX73tTCW2psFGdWj4QFvYB\n"
            + "U8b1xGsTLR6r05J7MpcOuiQJInpOlPPdoqRjpnIvGwE1hH+rzmMuySBRAnm/5YNg\n"
            + "EZjalf7v+lYwpDnSis+mZzF8ZeK8GknKM7AQPNcthgojn9HKF0EYf+CIyMXEPcI8\n"
            + "vzUjneejRMGnu5WS4QMbDUS+KAu/HNGclrrt4Jfoez35tdRj7xlhkIk1edCGG+3a\n"
            + "8eMA7LHCr+GQPn6XwbVv8SmHahYAkHA6+WNnHRGJbLU9D903CfnbzPP79FU2bker\n"
            + "aPQkmBhRJKiLqiwoso/kKiAsBaOS26FUvFU=\n"
            + "-----END CERTIFICATE-----";

        private const string SM2AppCert = @"-----BEGIN CERTIFICATE-----
MIICLjCCAdOgAwIBAgIQIBkRFb6w7pqtmULRNvJHtDAMBggqgRzPVQGDdQUAMIGE
MQswCQYDVQQGEwJDTjEWMBQGA1UECgwNQW50IEZpbmFuY2lhbDElMCMGA1UECwwc
Q2VydGlmaWNhdGlvbiBBdXRob3JpdHkgdGVzdDE2MDQGA1UEAwwtQW50IEZpbmFu
Y2lhbCBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eSBTMSB0ZXN0MB4XDTE5MTExNTA3
NTMyN1oXDTIyMTExNDA3NTMyN1owVjELMAkGA1UEBhMCQ04xEzARBgNVBAoMCnJl
c3TmtYvor5UxDzANBgNVBAsMBmFsaXBheTEhMB8GA1UEAwwYMTIzNDU2Nzg5MDA5
ODc2NTQzMjExMjM0MFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAERPDnzgyn7LI1
wMyKHFrLTfxbVG2+hoDbZuy30ykrh1N50moR5GQecxXABpd6hRkPOENj+tuMQL8f
3gJzcBl7sqNSMFAwHwYDVR0jBBgwFoAUJF/rdWc4prkOMF6f4lcd+t/NBrgwHQYD
VR0OBBYEFA3Jmcmg7L4mg6YZtNd/EWDtcIYoMA4GA1UdDwEB/wQEAwIGwDAMBggq
gRzPVQGDdQUAA0cAMEQCICXvkFdEsB/civLi0vE8QRDA3dljv64T6aKAbsOonl8c
AiBVtpMVM5HwOZ5CiF1o66GoUTcYNt3e2tS9Sp63PP7LLg==
-----END CERTIFICATE-----";



        [Test()]
        public void should_get_correct_rsa_app_cert_sn()
        {
            X509Certificate cert = AntCertificationUtil.ParseCert(File.ReadAllText(TestAccount.ProdCert.GetConfig().AppCertPath));
            string sn = AntCertificationUtil.GetCertSN(cert);

            Assert.AreEqual(sn, "47a27aac8ae3b5c589576f371da36dc2");
        }

        [Test()]
        public void should_return_correct_sm2_app_cert_sn()
        {
            X509Certificate cert = AntCertificationUtil.ParseCert(SM2AppCert);
            string sn = AntCertificationUtil.GetCertSN(cert);

            Assert.AreEqual(sn, "33ab704a3a749810b8d330f651c1ca20");
        }

        [Test()]
        public void should_get_correct_root_rsa_cert_sn()
        {
            string rootCertContent = File.ReadAllText(TestAccount.ProdCert.GetConfig().RootCertPath);
            string sn = AntCertificationUtil.GetRootCertSN(rootCertContent, "RSA");

            Assert.AreEqual(sn, "687b59193f3f462dd5336e5abf83c5d8_02941eef3187dddf3d3b83462e1dfcf6");
        }

        [Test()]
        public void should_return_true_if_cert_trusted()
        {
            string rootCertContent = File.ReadAllText(TestAccount.ProdCert.GetConfig().RootCertPath);
            string certContent = File.ReadAllText(TestAccount.ProdCert.GetConfig().AlipayPublicCertPath);
            bool result = AntCertificationUtil.IsTrusted(certContent, rootCertContent);

            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_return_false_if_cert_not_trusted()
        {
            string rootCertContent = File.ReadAllText(TestAccount.ProdCert.GetConfig().RootCertPath);
            string certContent = File.ReadAllText(TestAccount.ProdCert.GetConfig().AppCertPath);
            bool result = AntCertificationUtil.IsTrusted(certContent, rootCertContent);

            Assert.AreEqual(result, false);
        }

        [Test()]
        public void should_return_correct_pem_public_key_from_rsa_cert()
        {
            string certContent = File.ReadAllText(TestAccount.ProdCert.GetConfig().AlipayPublicCertPath);
            X509Certificate cert = AntCertificationUtil.ParseCert(certContent);
            string pemPublicKey = AntCertificationUtil.ExtractPemPublicKeyFromCert(cert);

            Assert.AreEqual(pemPublicKey, @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAm6XbUBCMaFxGXmIs5prnt8QR5B9BJmo/zkE8t4dkLVIbqd0LcCXlq1cyHlCDoqSsUNAQBSxZ9c7SWa+wfzpdNPz48rMCR6E7rmqx0t7btYJfUAwMYYRqyd+zeO+jmquj6ZPeibxFjlvIn83eP8OkGuhmN8gWif8EihDAlrANeN+lbmToAc9HNLRIaxj6mhn+cG8JizoSZU4WoxMMGVqYWoFJt/rGDlQLipQd19k5t/p09M87dB0wO/LH9rE74xpBbzqJGfvwdSVI4Lirz+ZRvDDmsewpesMOFDwEtmWUVmxZLLrJegwRZC9C3RJ2N6UwuKsc09qxCD0N+ym16kMZLQIDAQAB");
        }

        [Test()]
        public void should_return_correct_pem_public_key_from_sm2_cert()
        {
            X509Certificate cert = AntCertificationUtil.ParseCert(SM2AppCert);
            string publicKey = AntCertificationUtil.ExtractPemPublicKeyFromCert(cert);

            Assert.AreEqual(publicKey, "MFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAERPDnzgyn7LI1wMyKHFrLTfxbVG2+hoDbZuy30ykrh1N50moR5GQecxXABpd6hRkPOENj+tuMQL8f3gJzcBl7sg==");
        }
    }
}
