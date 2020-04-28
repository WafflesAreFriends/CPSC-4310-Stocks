# **CPSC-4310-Stocks** # 

## **Datasets** ##
### **2018_Financial_Data.csv** ###
This dataset is a collection of over 200+ financial indicators including a "class" attibute that indicates wether or not to buy a stock.    

**Size**    
Raw: 4392 rows (stocks) by 225 column attributes (indicators) - 8.6MB     
Processed: ~1200 rows (stocks) by 8 column attributes (indicators)  

**Samples**
 |**priceCashFlowRatio**|**priceEarningsRatio**|**priceEarningsToGrowthRatio**|**priceBookValueRatio**|**currentRatio**|**quickRatio**|**payoutRatio**|**Class**
:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:
0|6.3424931159579|13.3008|13.136438090395|2.1632|0.792|0.54044850197442|0.358|1
1|6.600806186793599|23.303|20.688542945929|1.0271|0.757|0.6322614794230501|1.098|1
2|7.2615573355531|10.2691|10.151624732817|2.8625|1.731|1.1050162396247|0.263|1
3|3.493075862069|4.2999|4.2999306685532|1.8919|2.787|2.1341675356274|0.0|1
5|6.2293514461032|9.3333|8.7463661900025|0.9151|0.41173975018571|0.41079879921765|0.205|1
4371|9.6993371671239|11.1406|11.094901953981|1.0313|0.060569839423475|0.05729145775674201|0.086|1
4375|17.592286253943|20.4633|20.402041621019002|0.0|1.943|1.8165549173696005|0.07200000000000001|1
4379|3.0477157758435|12.8205|11.974645845110002|1.0845|1.543|1.4911556869158|1.09|1
4381|6.4625590820905|14.2672|13.907427144659|0.8893|0.043901805429277|0.041725406213667|0.276|1
4385|3.1332155983619|18.8333|18.986480183824|0.206|1.481|1.2315090593199|0.0|1

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

### **aapl.us.txt** ###
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
