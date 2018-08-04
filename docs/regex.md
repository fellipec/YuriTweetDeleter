# Regular Expression Examples

### All retweets

`^RT`

### Retweets from a user

`^RT @user`

### Tweets with embed video

`/[0-9]*/video/?`

### Tweets with embed photos or GIFs

`(\/[0-9]*\/photo\/?)|(twimg\.com.*[jpg|gif])`

### Tweets that contains a valid URL 

`(http|https|ftp):[\/]{2}([a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,4})(:[0-9]+)?\/?([a-zA-Z0-9\-\._\?\,\'\/\\\+&amp;%\$#\=~]*)`

### Tweets that are ONLY a URL 

`^(http|https|ftp):[\/]{2}([a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,4})(:[0-9]+)?\/?([a-zA-Z0-9\-\._\?\,\'\/\\\+&amp;%\$#\=~]*)`

[Source](https://www.sitepoint.com/demystifying-regex-with-practical-examples/)

### Telephone numbers in format 999-9999 to 99999-9999 where the - could be any character or even not be there

`[0-9]{3,5}.?[0-9]{4}`

### American Express, Visa (16 digit), Master Card and Discover credit card numbers

`((?:(?:4\d{3})|(?:5[1-5]\d{2})|6(?:011|5[0-9]{2}))(?:-?|\040?)(?:\d{4}(?:-?|\040?)){3}|(?:3[4,7]\d{2})(?:-?|\040?)\d{6}(?:-?|\040?)\d{5})`

[Source](https://support.sumologic.com/hc/en-us/articles/205565718-Regular-expression-for-masking-credit-card-numbers)

# Regular Expression resources

* [RegExr - A tool to test and learn Regular Expressions](https://regexr.com/)
* [Demystifying RegEx with Practical Examples](https://www.sitepoint.com/demystifying-regex-with-practical-examples/)
* [Regular Expressions Tutorial](https://www.regular-expressions.info/tutorial.html)
* [8 Regular Expressions You Should Know](https://code.tutsplus.com/tutorials/8-regular-expressions-you-should-know--net-6149)
* [Regex Cheat Sheet](https://www.rexegg.com/regex-quickstart.html)
* [Regex tutorial — A quick cheatsheet by examples](https://medium.com/factory-mind/regex-tutorial-a-simple-cheatsheet-by-examples-649dc1c3f285)
* [Wikipedia - Regular expression](https://en.wikipedia.org/wiki/Regular_expression)