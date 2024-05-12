import { createRouter, createWebHistory } from 'vue-router'
import AppLayout from '../views/Layouts/AppLayout.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: AppLayout
    },
    {
      path: '/admin',
      name: 'about',
      component: AppLayout,
      children: [
        {
          path: 'dashboard',
          component: () => import('../views/AdminSite/dashboardView.vue')
        },
        {
          path: 'create-event',
          component: () => import('../views/AdminSite/CreateEvent.vue')
        },
        {
          path: 'all-events',
          component: () => import('../views/AdminSite/AllEvents.vue')
        },
        {
          path: 'detail-screen',
          component: () => import('../views/AdminSite/DetailScreen.vue')
        }
      ]
    }
  ]
})

export default router
