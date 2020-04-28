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
| float64 |      | -    |

_'priceEarningsRatio'_    
The price to earnings ratio (PE Ratio) is a measure of the share price relative to the annual net income earned by the firm per share. This ratio indicates current demand for a certain stock by investors.    
| type:   | mean: | std: |
|---------|-------|------|
| float64 | 10.460731 | 16.746056 |

_'priceEarningsToGrowthRatio'_   
The price/earnings to growth ratio (PEG Ratio) is a valuation metric for determining the relative trade-off between the price of a stock, the earnings generated per share (EPS), and the company's expected growth.    
| type:   | mean: | std: |
|---------|-------|------|
| float64 | -     | -    |

_'priceBookValueRatio'_  

| type:   | mean: | std: |
|---------|-------|------|
| float64 | -     | -    |

_'currentRatio'_    
| type:   | mean: | std: |
|---------|-------|------|
| float64 | -     | -    |

_'quickRatio'_    
| type:   | mean: | std: |
|---------|-------|------|
| float64 | -     | -    |

_'payoutRatio'_   
| type:   | mean: | std: |
|---------|-------|------|
| float64 | -     | -    |  

_'Class'_   
| type:   | mean: | std: |
|---------|-------|------|
| int64 | -     | -    |

### aapl.us.txt ###
This data set is a collection of Apple Inc. daily stock market prices since 1984. For our purposes we will be using the data since 2007, as the advent of the iPhone changed the economic and corporate landscape. 

**Size**      
Raw: 8364 rows (daily metrics) by 7 column attributes (values) - 428kB    
Processed: -- rows (daily metrics) by 6 column attributes (values)   

**Samples**

**Attribute Descriptions**    
_'Date'_        

_'Open'_        

_'High'_        

_'Low'_      

_'Close'_      

_'Volume'_        
