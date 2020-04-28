# **CPSC-4310-Stocks** # 

## **Datasets** ##
### **2018_Financial_Data.csv** ###
This dataset is a collection of over 200+ financial indicators including a "class" attibute that indicates wether or not to buy a stock.    

**Size**    
Raw: 4392 rows (stocks) by 225 column attributes (indicators) - 8.6MB     
Processed: ~1200 rows (stocks) by 8 column attributes (indicators)  

**Samples**

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

_'Volume'_ (float64)        
The volume is the number of shares that changed hands during a given day.
