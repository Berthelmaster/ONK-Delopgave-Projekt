import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import VueRouter from 'vue-router'
import Create from './views/Create.vue'
import Delete from './views/Delete.vue'
import Read from './views/Read.vue'
import Update from './views/Update.vue'
import Frontpage from './views/Frontpage.vue'

Vue.config.productionTip = false
Vue.use(VueRouter)

const router = new VueRouter({
  routes: [
    {
      path: '', component: Frontpage
    },
    {
      path: '/Create', component: Create
    },
    {
      path: '/Delete', component: Delete
    },
    {
      path: '/Read', component: Read
    },
    {
      path: '/Update', component: Update
    }
  ],
  mode: 'history'
})

new Vue({
  vuetify,
  router,
  render: h => h(App),
}).$mount('#app')
