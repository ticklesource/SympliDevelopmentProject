![sympli logo!](https://www.sympli.com.au/wp-content/uploads/sympli-logo-black.svg)

For current open positions, see <https://www.linkedin.com/company/sympli-australia/jobs>.

------------------------------------

# Hiring @ Sympli

Hello! If you are reading this then you're likely in the process of interviewing with a technical role at [Sympli](https://www.sympli.com.au/). If so, congratulations :tada: !

In order to move forward, we'd like to know a little about how you work. To that end, this repository contains a **short, time-boxed** (approximately 1-1.5 hours max) that you can use demonstrate your skills and abilities.

Your task is to build an API that fulfills the requirements below. We have set up the project and defined the API for you to have a quicker start.

## Before you get started

We know that the technical hiring processes in our industry are generally broken. We also know that there are mixed opinions on take-home exercises in general. The reason we ask for it is mainly because it allows you to work at your own pace and eliminates the anxiety of writing code with someone whom you've just met.

That being said, for those candidates who are not a fan of take-home exercises we do offer the following alternatives:
- Whiteboarding/Live-coding interviews where you will be given a problem to solve during the interview that involves writing some code.
- Show-your-code where you bring a code repo that you're proud of in and we will review the codebase together. Please note the code repo should contain no intellectual properties of a third party.

Whichever way you pick, we understand this is a time investment for you. You should probably not spend any time on it before you have a fair understanding of Sympli and the role. Feel free to contact Amee our Talent Acquisition Manager at <amee.karat@sympli.com.au> for any questions. You're also more than welcome to ask for a chat with the hiring manager directly.

We intentionally design this exercise to take 1-1.5 hours and ask you to limit your commitment to no more than the suggested time.

## The problem

The CEO at Sympli is very interested in SEO and how this can improve Sales. Every morning he logs into `google.com.au` and types in the same key words `e-settlements` and counts down to see where and how many times their company, `www.sympli.com.au` sits on the list.

Seeing the CEO do this every day, a smart software developer at Sympli decides to write an application for him that will automatically perform this operation and return the result to the screen. They design and code some software that receives a string of keywords, and a string URL. This is then processed to return a string of numbers for where the resulting URL is found in the Google results.

For example, `1, 10, 33` or `0`.

The CEO is only interested if their URL appears in the first `100` results.

Ideally your solution should be able to run locally and test the results so we can fully analyze your efforts.

### Extension 1

The CTO at Sympli has become interested in this project and has added a requirement that the number of calls made to google be limited to one per hour per search. He has proposed that you introduce caching to satisfy this requirement.

### Extension 2

The CEO is impressed with your work. He would like the application to be extended so that he can see and compare results from other search engines, such as Bing. As a developer, you anticipate that further search engines may also require support in the future.

## Expectation
The solution is written in C# and compiles/runs with .NET6.

***Do not use any 3rd party libraries that are not part of the .NET framework in your solution and do not use Google Search API.***

The `controller` has been created for you and the `GetResult` method is recommended to start with.

The problem itself is not designed to be overly complex however the expectation is that candidates will approach this as if it were a real project and deliver production quality code. When assessing this project, we will be reviewing not only that you have solved the problems as per the requirements, but **how** you have solved it and the quality of both your code and deliverable.

**For applicants applying for a senior role, extensions 1 and 2 are mandatory.**

Be sure to update the `README.md` file in your submission and include the following information:
- A few screenshots of the finished product
- A super-simple test suite if applicable
- How to test/demo/run
- Some form of lightweight technical documentation (code comments are fine)
- A list of what you would add/change if you had more time
- Anything else you'd lke us to know about your submission

## How to submit

Create a new **private repository** using this one as a template for your exercise and add the Sympli hiring team members as private collaborators. We do this to preserve your anonymity so it's not obvious you are looking for a new role.
- [Xinxin Li](https://github.com/xinxin-sympli)
- [Mark Panetta](https://github.com/mjpanetta)

## Next Step

Once finished, share the link with Amee our Talent Acquisition Manager at <amee.karat@sympli.com.au> and we will get back to you within 48 hours.

## Have fun  :smiley:
