---
layout: default
title: Grading Criteria
layout: default
---
{% for assessment in site.grading %}
   <h2><a href="{{ assessment.url | prepend: site.baseurl }}"><span class="assessment-subtitle">{{ assessment.subtitle }}</span></a></h2>
   <p>{{content}}</p>
{% endfor %}
