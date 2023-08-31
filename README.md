# TDD Exercise with Test-Doubles

Shipping Cost Service

We are going to test drive a service for calculating the shipping cost of a package or letter.

- If the destination country is in the common market, a flat rate of 5 is calculated
- If the destination country is North America and the delivery type is
  Express a flat rate of 50 is calculated
  Standard a flat rate of 35 is calculated
- Any other country costs the km multiplied by 9% but a minimum of 15

Design with TDD the interface of another service to calculate the shipping costs. This service will use some REST call to retrieve the required information

## Contribute

If you would like to contribute to this kata adding new cases or smells: please open a pull request!

## Feedback

Feedback is welcome!

How did you find the kata? Did you learn anything from it?

You can [contact me](https://github.com/afhswe) or contact the original author via twitter [@racingDeveloper](https://twitter.com/racingDeveloper) or using the original GitHub repo wiki!
