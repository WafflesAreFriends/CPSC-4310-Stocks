# **CPSC-4310-Stocks** # 

## **Datasets** ##
### **2018_Financial_Data.csv** ###
This dataset is a collection of over 200+ financial indicators including a "class" attibute that indicates wether or not to buy a stock.    

**Size**    
Raw: 4392 rows (stocks) by 225 column attributes (indicators) - 8.6MB     
Processed: ~1200 rows (stocks) by 8 column attributes (indicators)  

**Samples**
|      | priceCashFlowRatio  | priceEarningsRatio | priceEarningsToGrowthRatio | priceBookValueRatio | currentRatio       | quickRatio          | payoutRatio | Class |
|------|---------------------|--------------------|----------------------------|---------------------|--------------------|---------------------|-------------|-------|
| 0    | 6\.3424931159579    | 13\.3008           | 13\.136438090395           | 2\.1632             | 0\.792             | 0\.54044850197442   | 0\.358      | 1     |
| 2    | 7\.2615573355531    | 10\.2691           | 10\.151624732817           | 2\.8625             | 1\.731             | 1\.1050162396247    | 0\.263      | 1     |
| 3    | 3\.493075862069     | 4\.2999            | 4\.2999306685532           | 1\.8919             | 2\.787             | 2\.1341675356274    | 0\.0        | 1     |
| 4    | 14\.889427521079    | 0\.0               | 47\.51407396171606         | 2\.0436             | 1\.7182084143933   | 1\.4025869878373    | \-0\.141    | 1     |
| 5    | 6\.2293514461032    | 9\.3333            | 8\.7463661900025           | 0\.9151             | 0\.41173975018571  | 0\.41079879921765   | 0\.205      | 1     |
| 4383 | 216\.28890485831377 | 0\.0               | 47\.51407396171606         | 1\.5564             | 0\.746             | 0\.39887472590118   | 0\.0        | 0     |
| 4384 | 216\.28890485831377 | 0\.0               | 47\.51407396171606         | 4\.3967             | 5\.78              | 5\.3746603260870005 | 0\.0        | 1     |
| 4385 | 3\.1332155983619    | 18\.8333           | 18\.986480183824           | 0\.206              | 1\.481             | 1\.2315090593199    | 0\.0        | 1     |
| 4387 | 216\.28890485831377 | 0\.0               | 47\.51407396171606         | 3\.9828             | 4\.271088718119423 | 0\.0021422799090826 | 0\.0        | 0     |
| 4388 | 216\.28890485831377 | 0\.0               | 47\.51407396171606         | 1\.4604             | 3\.886             | 3\.8153564899452    | 0\.0        | 0     |


**Attribute Descriptions**    
_'priceCashFlowRatio'_ (float64)      
The prive to cash flow ratio is used to compare a company's market value to its cashflow. Theoretically, the lower the value the better the stock is.

_'priceEarningsRatio'_ (float64)          
The price to earnings ratio (PE Ratio) is a measure of the share price relative to the annual net income earned by the firm per share. This ratio indicates current demand for a certain stock by investors.

_'priceEarningsToGrowthRatio'_ (float64)        
The price/earnings to growth ratio (PEG Ratio) is a valuation metric for determining the relative trade-off between the price of a stock, the earnings generated per share (EPS), and the company's expected growth.

_'priceBookValueRatio'_ (float64)         
The price to book value ratio (PBV Ratio) is the market price per share divided by the book value per share. Traditionally, a value under 3.0 is fair and under 1.0 is undervalued and thus very good.

_'currentRatio'_ (float64)          
The current ratio is a liquidity ratio that measures whether a firm has enough resources to meet its short-term obligations. A good current ratio is between 1.2 to 2, which means that the business has 2 times more current assets than liabilities to covers its debts.

_'quickRatio'_ (float64)         
The quick ratio is a financial ratio used to gauge a company's liquidity. A result of 1 is considered to be the normal quick ratio. 

_'payoutRatio'_ (float64)           
The payout ratio is the percentage of net income that a company pays out as dividends to common shareholders. A payout ratio of 10% means for every dollar in Net Income, 10% is being paid out as a dividend. 

_'Class'_ (int64)         
The predetermined classes of 1 and 0 - where the former represnets buy the stock now and sell at the end of the year and 0 represents don't buy at all. 

### **aapl.us.txt** ###
This data set is a collection of Apple Inc. daily stock market prices since 1984. For our purposes we will be using the data since 2007, as the advent of the iPhone changed the economic and corporate landscape. 

**Size**      
Raw: 8364 rows (daily metrics) by 7 column attributes (values) - 428kB    
Processed: ~2700 rows (daily metrics) by 6 column attributes (values)   

**Samples**
| Date         | Open                | High    | Low                 | Close               | Volume    |
|--------------|---------------------|---------|---------------------|---------------------|-----------|
| 2007\-01\-03 | 11\.049000000000001 | 11\.087 | 10\.485999999999999 | 10\.731             | 345302870 |
| 2007\-01\-04 | 10\.78              | 11\.007 | 10\.732999999999999 | 10\.969000000000001 | 236252357 |
| 2007\-01\-05 | 10\.992             | 11\.038 | 10\.807             | 10\.892999999999999 | 232773093 |
| 2007\-01\-08 | 11\.011             | 11\.081 | 10\.922             | 10\.946             | 222149027 |
| 2007\-01\-09 | 11\.075             | 11\.907 | 10\.905999999999999 | 11\.854000000000001 | 933759387 |
| 2017\-11\-06 | 171\.75             | 174\.36 | 171\.1              | 173\.63             | 34901241  |
| 2017\-11\-07 | 173\.29             | 174\.51 | 173\.29             | 174\.18             | 24424877  |
| 2017\-11\-08 | 174\.03             | 175\.61 | 173\.71             | 175\.61             | 24451166  |
| 2017\-11\-09 | 174\.48             | 175\.46 | 172\.52             | 175\.25             | 29533086  |
| 2017\-11\-10 | 175\.11             | 175\.38 | 174\.27             | 174\.67             | 25130494  |

**Attribute Descriptions**    
_'Date'_ (date)             
The date the of the trading day corresponding to the recorded values.  

_'Open'_ (float64)             
The opening price is the price at which a security first trades upon the opening of an exchange on a trading day. For our data, this is a price of Apple's shares on open. 

_'High'_ (float64)      
The high is the highest price at which a stock traded during the course of the trading day.

_'Low'_ (float64)            
The low is the lowest price at which a stock traded during the course of the trading day

_'Close'_ (float64)            
The closing price is the last price at which the stock traded during the regular trading day.

_'Volume'_ (int64)        
The volume is the number of shares that changed hands during a given day.
