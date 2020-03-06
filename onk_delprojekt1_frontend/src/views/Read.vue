<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Read HaandVaerker</h3>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Read Vaerkstoejskasse</h3>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Read HaandVaerker</h3>
                </div>
        </v-row>
    </v-container>
</template>


<script>
import axios from 'axios';

export default {
    data() {
        return {
            posts: []
            }
    },  

created() {
    axios.get('http://jsonplaceholder.typicode.com/posts')
    .then(reponse => {
        this.posts = reponse.data
    })}}
</script>