<template>
    <div>
        <v-row>
            <p class="font-weight-bold">Overview</p>
        </v-row>
        <v-row>
            <v-col cols="4">
                <v-card class="dashboardBoard">
                   <v-card-text>
                    All Events
                   </v-card-text>
                   <v-card-text class="d-flex justify-center text-h4">
                    03
                   </v-card-text>
                </v-card>
            </v-col>
            <v-col cols="8">
                <v-card class="dashboardBoard">
                   <v-card-text>
                    Days to Events
                   </v-card-text>
                   <v-card-text class="d-flex justify-center text-h4">
                    03
                   </v-card-text>
                </v-card>
            </v-col>
            <v-col cols="8">
                <v-card class="dashboardBoard">
                    <v-card-text>
                        Registrations
                    </v-card-text>
                    <v-img max-height="150" src="https://cdn.corporatefinanceinstitute.com/assets/line-graph.jpg"></v-img>    
                </v-card>
            </v-col>
            <v-col cols="4">
                <v-card class="dashboardBoard">
                    <v-card-text>
                        Registrations
                    </v-card-text>
                    <v-img  max-height="150" src="https://cdn-icons-png.flaticon.com/512/3589/3589863.png"></v-img>
                </v-card>
            </v-col>
            <v-col cols="12">
                <v-card height="250" class="dashboardBoard">
                    <v-card-text>
                        Event Lists
                    </v-card-text>
                    <v-card-item>
                        <event-list/>
                    </v-card-item>
                </v-card>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import EventList from './components/EventList.vue';

export default {
    components: {
        EventList
    }}
</script>

<style>
    .dashboardBoard {
        border: 1px solid rgba(255, 127, 0, 0.2) ;
        box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.2);
    }
</style>