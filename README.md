# **CPSC-4310-Stocks** # 

## Datasets ##
### 2018_Financial_Data.csv ###
This dataset is a collection of over 200+ financial indicators including a "class" attibute that indicates wether or not to buy a stock.    

**Size**    
Raw: 4392 rows (stocks) by 225 column attributes (indicators) - 8.6MB     
Processed: ~1200 rows (stocks) by 8 column attributes (indicators)  

**Samples**

**Attribute Descriptions**    
_'priceCashFlowRatio'_   
The prive to cash flow ratio is used to compare a company's market value to its cashflow. Theoretically, the lower the value the better the stock is.
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 10.460731 | 5.522658 |

_'priceEarningsRatio'_    
The price to earnings ratio (PE Ratio) is a measure of the share price relative to the annual net income earned by the firm per share. This ratio indicates current demand for a certain stock by investors.
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 16.746056 | 9.051715 |

_'priceEarningsToGrowthRatio'_   
The price/earnings to growth ratio (PEG Ratio) is a valuation metric for determining the relative trade-off between the price of a stock, the earnings generated per share (EPS), and the company's expected growth.
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 16.537492 | 8.929073 |

_'priceBookValueRatio'_   
The price to book value ratio (PBV Ratio) is the market price per share divided by the book value per share. Traditionally, a value under 3.0 is fair and under 1.0 is undervalued and thus very good.
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 2.064655 | 1.392249 |

_'currentRatio'_    
The current ratio is a liquidity ratio that measures whether a firm has enough resources to meet its short-term obligations. A good current ratio is between 1.2 to 2, which means that the business has 2 times more current assets than liabilities to covers its debts.
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 1.351343 | 1.114096 |

_'quickRatio'_    
The quick ratio is a financial ratio used to gauge a company's liquidity. A result of 1 is considered to be the normal quick ratio. 
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 0.877048 | 0.780241 |

_'payoutRatio'_     
The payout ratio is the percentage of net income that a company pays out as dividends to common shareholders. A payout ratio of 10% means for every dollar in Net Income, 10% is being paid out as a dividend.
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 0.302907 | 0.302167 |  

_'Class'_   
The predetermined classes of 1 and 0 - where the former represnets buy the stock now and sell at the end of the year and 0 represents don't buy at all. 
| type:   | mean: | std: |
|---------|-------|------|
| int64 | 1 | 0.302167 |

### aapl.us.txt ###
This data set is a collection of Apple Inc. daily stock market prices since 1984. For our purposes we will be using the data since 2007, as the advent of the iPhone changed the economic and corporate landscape. 

**Size**      
Raw: 8364 rows (daily metrics) by 7 column attributes (values) - 428kB    
Processed: ~2700 rows (daily metrics) by 6 column attributes (values)   

**Samples**

**Attribute Descriptions**    
_'Date'_        

_'Open'_        

_'High'_        

_'Low'_      

_'Close'_      

_'Volume'_        
