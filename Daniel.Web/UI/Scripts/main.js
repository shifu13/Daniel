// Lazysizes
import 'lazysizes';

// Alpine bootup

import Alpine from 'alpinejs';
import intersect from '@alpinejs/intersect'
import persist from '@alpinejs/persist'
import focus from '@alpinejs/focus'
import collapse from '@alpinejs/collapse'

import { tns } from "tiny-slider/src/tiny-slider"
window.tns = tns

window.Alpine = Alpine;
Alpine.start();
Alpine.plugin(intersect);
Alpine.plugin(persist);
Alpine.plugin(focus);
Alpine.plugin(collapse);

// aspnet-client-validation bootup

import { ValidationService } from 'aspnet-client-validation';

let v = new ValidationService();
v.bootstrap();