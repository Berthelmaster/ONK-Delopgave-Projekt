import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import VueRouter from 'vue-router'
import Post from './views/Post.vue'
import Delete from './views/Delete.vue'
import Get from './views/Get.vue'
import Update from './views/Update.vue'
import Frontpage from './views/Frontpage.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.config.productionTip = false
Vue.use(VueRouter)
Vue.use(VueAxios, axios)

const router = new VueRouter({
  routes: [
    {
      path: '/', component: Frontpage
    },
    {
      path: '/Post', component: Post
    },
    {
      path: '/Delete', component: Delete
    },
    {
      path: '/Get', component: Get
    },
    {
      path: '/Update', component: Update
    }
  ],
  mode: 'history'
});

new Vue({
  vuetify,
  router,
  render: h => h(App),
}).$mount('#app')
