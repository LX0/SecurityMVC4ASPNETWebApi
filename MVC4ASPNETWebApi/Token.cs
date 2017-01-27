using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4ASPNETWebApi
{
    public class Token
    {
        //public  const String ChiavePrivata = "<RSAKeyValue><Modulus>utMwYMd7zL/qyOfLMbjnQ3LTI2CD6jcOKthdSgSm4Xr+npbqjfOfD/5wxs+veFOm3oV54pTapNGNoBtPaB534raP74y38cYN7gXIJ3w8qRLPHmzqHZtJ7zhQuMcCgZo8l6KmfkePeIJZJYvABwS4K+ulNnAPFHb/P+tMTuUOXTE=</Modulus><Exponent>AQAB</Exponent><P>2/TK55riFrDFl/U2PsmBrDyc3Tang/ANWR0B2EAdeWSJaMMc1mk7H7mlGyFLGMaElgxVWRL3q5LSXXPzJlXC5Q==</P><Q>2XCIge9vO2gEW0vpGCKKYecMsJHD8bRopkkXMojwYZvSB0FT/Uthc3I3/j/fobn8gAvWjYrAVGooDrk7pBNQXQ==</Q><DP>jGCEhp/Anz6ePMcQoa21BpmAe2YALyIrQq5SmRMCPJE/aQ7s/qIWS78Ncm0jImLAB4tDhR+n1WZUv7PagKLHSQ==</DP><DQ>hSdhoNhEMIfpKxNYYbw9K+j2n2YULP7CmxnlR8AOHGf0fRbnXRR9T9ohKeRpiTtAwhT9xV2zm74KW8HZIQfmzQ==</DQ><InverseQ>1irPS1d8mwo5hAiqjbEguRseKWba1rscOOslIrttnjfsEwhzJHPyl7ljJJ7JJnYHXGKR86cx1453rJpetoRgqg==</InverseQ><D>sFfPfkpNDMLKNsC0B0bk48FqkiXz3gwBj2eTBt7FNmgGFmOVGlAuf8ZHZSF8GzO6eqe6mKiwiIpUCCA/H6RCu1uCgMajtqQ9a8MhOgsewFc8D6DeCW2Hd5jFvejIwfxsOtYAKHqGxrpIH+30pDJZwSK5coyxN/oNZtPK6V69TcE=</D></RSAKeyValue>";
        //public  const String ChiavePubblica = "<RSAKeyValue><Modulus>nV5FI82ywwKH+Eqt6iT6IFfW2b6+et5/t7GSz/ewgfV0R87Ny1Owm2qdOkGm2lqgKFtA8+Ej3PTJBMCN2Xk2FcxTuf3OLyx2460llyMvyCHUlvqfpkDWtYGGuDz2W+iYGasq9GoPgEcQTnkZsfrn9ezP1isefaibV5tKowiusKU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public const String ChiavePrivata = "<RSAKeyValue><Modulus>vMhVPRvMnhboDJylnh3wXZNq9v5eqfqOlADqWpC32VaNqa49vwsywTjnUju+s8ywZnTKdEBuZz3fC55HVeypJeaHcoqEUtE8fIgW8uPjhP7gYyS1ZYYmFz0kNNdUSyTiqA6zhUCwnlWCTNAa5dknVHFrIKQIubUGBwNj3LGPGG7kvDqxQgoz8Z1IFy5ns9Xve0IhbLKbmQVhRo7uJijqVsz4nrRatbFAdkBFFN8Yj/HhPLI1wQ5hb79hPQWgPQ3PTjeuCNYnkt95BmAoROKNlZh13f6kGBGJgA2STpedW5V2EtxuixLjfTJ7BM2gTVP0iV+a1HO5qrr4jntKALmndQ==</Modulus><Exponent>AQAB</Exponent><P>90W3Q9ifH3cZfHasWYJPgJZiQ8pGBvucmdvMvtz12phAjI5pN9uLZOQAgSXppRRr+VDsEXQu3gdU/sVRkjAO22tt2q195SDndG796XhBNx95PHDIxcqSfwr83ChNYklh523EDiPhAWtlSn8qlVlaclvyzIaBtR9Rf05dHi2A9R0=</P><Q>w3IepD+cx6K8KKe/7FoMuUYJtWMi/gME/N2C1tYtCdSWjrO8AoKIosd44lHbWhT89tPjh2EUq0FTPyoIWlKY7SHUhE1FGre2qEiqr9zkRve3GYdxFas9dUexk9x0i0VudIp5p5g67MCRZjkGKYgcm9jyrRpB1pUauRgXao/HJDk=</Q><DP>3MZANLFqkVtzQ+9pPpnchgC/R6uIDqAEWFMpYZhDYqLhrx1P0HGS6cews564F44+QWIBBCxp1A9T0g03IYELItmuQbr5VuSkAw8+YX/fKmpNgqtod0DAv/F9hsvtG75NTaZxj/Z05SGQVI1p5eLboJN8GyRVFvQZfcLn3RPfufk=</DP><DQ>r3cD5WeqxFvoWwOHPZT2uVsUmkD/iFaDotTngyLTWnD+He1kzEgOjT1R3LWqnWwcUyiVq9PPb5R9PUbqKtTesH3fwktwz/TBSsG6Y5qHYuNAAe5j6xVKXsFXvqx8ARD7gitT3s+/jw+vObvWOXEWZiBWdmwNUa2ZSTVEyIl+Opk=</DQ><InverseQ>pAdkWrqhgRaxGYrA12Q9P1Wvgtl0+EevlVptVBl85mZo3Yl2HfUdw1Z6o4YiKkDh5zZA5XRkE/Dn62nFbC94IHkfprpsshez4aAemxHRnOzNUuGCQ/ZFmX+BWiOklAStvuJOFD6zzarRM5kK6B0R41IMjztAFdn9yEt7noyT4wo=</InverseQ><D>BDkO/xDyIM8uXanbYpAU4mL7z46dG3xJWDI1C9WU5z2yaYtGQlHDzuKw+fvwJiF8CK6wIK2YSqLtrFrcCaYDmp9vhDZpA1k+2yJIMSK74iu5ZT5a+GxpybdKagwvDIdEsrGxfleWG9SZ15IIKAAViyQGW3KP52ePPPTsdPFb3BYFDJgcj9zXhzQmBx6Al0tXrrfnqpLA1a9JxqMWHWyTEUq4qutgs9UGgjK0tUjyLIL/saMWE4g0EZvI5GHk4VSK7iIOpKf1CYuQvwoIHoDCKfe2TvN58Xc6GQu5vqETD6eRD+thAvAvSKPnwJL5z+nfFSCuQXO9c3cLgVm1VQbjQQ==</D></RSAKeyValue>";
        public const String ChiavePubblica = "<RSAKeyValue><Modulus>vMhVPRvMnhboDJylnh3wXZNq9v5eqfqOlADqWpC32VaNqa49vwsywTjnUju+s8ywZnTKdEBuZz3fC55HVeypJeaHcoqEUtE8fIgW8uPjhP7gYyS1ZYYmFz0kNNdUSyTiqA6zhUCwnlWCTNAa5dknVHFrIKQIubUGBwNj3LGPGG7kvDqxQgoz8Z1IFy5ns9Xve0IhbLKbmQVhRo7uJijqVsz4nrRatbFAdkBFFN8Yj/HhPLI1wQ5hb79hPQWgPQ3PTjeuCNYnkt95BmAoROKNlZh13f6kGBGJgA2STpedW5V2EtxuixLjfTJ7BM2gTVP0iV+a1HO5qrr4jntKALmndQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public const String Value = "322F3958-DEFD-4E05-94AE-8CAD7D69330A";

        public static IList<String> tokens { get; set;  }

        public static IQueryable<String> GetTokens()
        {

            if (tokens == null)
                tokens = new List<String>();

            return tokens.AsQueryable();
        }

        public static void AddToken(String token)
        {
            if (tokens == null)
                tokens = new List<String>();

            tokens.Add(token);
        }
    }
}