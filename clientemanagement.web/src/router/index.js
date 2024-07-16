import { createRouter, createWebHistory } from 'vue-router';
import ClienteList from '../components/ClienteList.vue';
import ClienteForm from '../components/ClienteForm.vue';

const routes = [
  {
    path: '/',
    name: 'ClienteList',
    component: ClienteList,
  },
  {
    path: '/add',
    name: 'AddCliente',
    component: ClienteForm,
  },
  {
    path: '/edit/:id',
    name: 'EditCliente',
    component: ClienteForm,
    props: true,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
